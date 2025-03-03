using LayerEntity.Inventory;
using LayerModel.Responses;
using Npgsql;
using System.Data;

namespace LayerData.Inventory.Impl
{
    public class AccessListPrice : IListPrice
    {
        public MessageResponse createPriceList(ListPrice listPrice)
        {
            string result = string.Empty;
            string querySql = "INSERT INTO \"public\".listprice(name_list, description, active, date_create, date_update) " +
                "VALUES (@name_list, @description, @active, @date_create, @date_update);";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                using var command = conn.CreateCommand();
                command.CommandText = querySql;
                addParameters(command, listPrice, false);
                conn.Open();
                var rowAffected = command.ExecuteNonQuery();
                result = rowAffected >= 1 ? "Registro Exitoso del precio." : "Error al registrar precio.";
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

        public MessageResponse deletePriceList(int listPrice)
        {
            string result = string.Empty;
            string querySql = "DELETE FROM \"public\".listprice lp WHERE lp.idlistprice = @idlistprice";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                using var command = conn.CreateCommand();
                command.CommandText = querySql;
                command.Parameters.AddWithValue("@idlistprice", listPrice);
                conn.Open();
                var rowAffected = command.ExecuteNonQuery();
                result = rowAffected >= 1 ? "Eliminacion Exitoso." : "Error al Eliminar.";
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

        public MessageResponse getAllPriceList()
        {
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dataTable = new DataTable();

            try
            {
                conn = AccesDB.getInstance().createConection();
                NpgsqlCommand command = new NpgsqlCommand("SELECT idlistprice, name_list, description, active, date_create, date_update FROM \"public\".listprice;", conn);
                command.CommandType = CommandType.Text;
                conn.Open();
                dataTable.Load(command.ExecuteReader());
                return ValidationErrors.SuccesMessage(dataTable, "Consulta exito de las listas de precios.");
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

        public MessageResponse updatePriceList(ListPrice listPrice)
        {
            string result = string.Empty;
            string querySql = "UPDATE \"public\".listprice SET " +
                "name_list= @name_list, description= @description, active= @active, date_update= @date_update " +
                "WHERE idlistprice = @idlistprice";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                using var command = conn.CreateCommand();
                command.CommandText = querySql;
                addParameters(command, listPrice, true);
                conn.Open();
                var rowAffected = command.ExecuteNonQuery();
                result = rowAffected >= 1 ? "Actualizacion Exitosa del precio." : "Error al actualizar el precio.";
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

        private void addParameters(NpgsqlCommand command, ListPrice listPrice, bool isUpdate)
        {
            var parameterCollection = command.Parameters;
            parameterCollection.AddWithValue("idlistprice", listPrice.idPriceList);
            parameterCollection.AddWithValue("name_list", listPrice.namePriceList);
            parameterCollection.AddWithValue("description", listPrice.descriptionPriceList);
            parameterCollection.AddWithValue("active", listPrice.activePriceList);
            parameterCollection.AddWithValue("date_create", listPrice.createPriceList);
            parameterCollection.AddWithValue("date_update", listPrice.updatePriceList);
        }
    }
}
