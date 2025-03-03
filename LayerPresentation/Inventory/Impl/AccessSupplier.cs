using LayerEntity.Inventory;
using LayerModel.Responses;
using Npgsql;
using System.Data;

namespace LayerData.Inventory.Impl
{
    public class AccessSupplier : ISupplier
    {
        public MessageResponse createSupplier(Supplier supplier)
        {
            string result;
            string querySql = "INSERT INTO \"public\".supplier(name_supplier, name_social, direccion, phonenumber1, phonenumber2, description)"
            + " VALUES (@name_supplier, @name_social, @direccion, @phonenumber1, @phonenumber2, @description);";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                using var command = conn.CreateCommand();
                command.CommandText = querySql;
                addParameters(command, supplier, false);
                conn.Open();
                var rowAffected = command.ExecuteNonQuery();
                result = rowAffected >= 1 ? "Registro Exitoso de proveedor." : "Error al registrar el proveedor.";
                return ValidationErrors.SuccesMessage(null, result);
            }
            catch (NpgsqlException ex)
            {
                return ValidationErrors.ValidationException(ex);
            }
            finally
            {
                if (conn.State.Equals(ConnectionState.Open)) conn.Close();
            }
        }

        public MessageResponse deleteSupplier(int idSupplier)
        {
            string result;
            string querySql = "DELETE FROM \"public\".supplier sp WHERE sp.idsupplier = @idsupplier";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                using var command = conn.CreateCommand();
                command.CommandText = querySql;
                command.Parameters.AddWithValue("@idsupplier", idSupplier);
                conn.Open();
                var rowAffected = command.ExecuteNonQuery();
                result = rowAffected >= 1 ? "Eliminacion Exitoso del proveedor." : "Error al Eliminar el proveedor.";
                return ValidationErrors.SuccesMessage(null, result);
            }
            catch (NpgsqlException ex)
            {
                return ValidationErrors.ValidationException(ex);
            }
            finally
            {
                if (conn.State.Equals(ConnectionState.Open)) conn.Close();
            }
        }

        public MessageResponse getAllSupplier()
        {
            NpgsqlDataReader result;
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dataTable = new DataTable();

            try
            {
                conn = AccesDB.getInstance().createConection();
                NpgsqlCommand command = new NpgsqlCommand("SELECT idsupplier, name_supplier, name_social, direccion, phonenumber1, phonenumber2, description FROM \"public\".supplier", conn);
                command.CommandType = CommandType.Text;
                conn.Open();
                result = command.ExecuteReader();
                dataTable.Load(result);
                return ValidationErrors.SuccesMessage(dataTable, "Consulta exitosa de proveedores");
            }
            catch (NpgsqlException ex)
            {
                return ValidationErrors.ValidationException(ex);
            }
            finally
            {
                if (conn.State.Equals(ConnectionState.Open)) conn.Close();
            }
        }

        public MessageResponse updateSupplier(Supplier supplier)
        {
            string result;
            string querySql = "UPDATE \"public\".supplier sp" +
                " SET name_supplier=@name_supplier, name_social=@name_social, direccion=@direccion, phonenumber1=@phonenumber1, phonenumber2=@phonenumber2, description=@description" +
                " WHERE sp.idsupplier = @idsupplier";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                using var command = conn.CreateCommand();
                command.CommandText = querySql;
                addParameters(command, supplier, true);
                conn.Open();
                var rowAffected = command.ExecuteNonQuery();
                result = rowAffected >= 1 ? "Actualizacion Exitosa del proveedor." : "Error al actualizar el proveedor.";
                return ValidationErrors.SuccesMessage(null, result);
            }
            catch (NpgsqlException ex)
            {
                return ValidationErrors.ValidationException(ex);
            }
            finally
            {
                if (conn.State.Equals(ConnectionState.Open)) conn.Close();
            }
        }

        private void addParameters(NpgsqlCommand command, Supplier supplier, bool isUpdate)
        {
            var parameterCollection = command.Parameters;
            parameterCollection.AddWithValue("idsupplier", supplier.idSupplier);
            parameterCollection.AddWithValue("name_supplier", supplier.nameSupplier);
            parameterCollection.AddWithValue("name_social", supplier.socialNameSupplier);
            parameterCollection.AddWithValue("direccion", supplier.addressSupplier);
            parameterCollection.AddWithValue("phonenumber1", supplier.numberOneSupplier);
            parameterCollection.AddWithValue("phonenumber2", supplier.numberTwoSupplier);
            parameterCollection.AddWithValue("description", supplier.descriptionSupplier);
        }
    }
}
