using LayerData.Inventory;
using LayerModel.Inventory;
using LayerModel.Responses;
using Npgsql;
using System.Data;

namespace LayerData.Inventory.Impl
{
    public class AccessCategory : ICategory
    {
        public MessageResponse getAllCategory()
        {
            NpgsqlDataReader result;
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dataTable = new DataTable();

            try
            {
                conn = AccesDB.getInstance().createConection();
                NpgsqlCommand command = new NpgsqlCommand("SELECT idcategory, name_category, description, date_create, date_update " +
                    "FROM \"public\".category;", conn);
                command.CommandType = CommandType.Text;
                conn.Open();
                result = command.ExecuteReader();
                dataTable.Load(result);
                return ValidationErrors.SuccesMessage(dataTable, "Consulta exitosa de Categorias");
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

        public MessageResponse createCategory(Category category)
        {
            string result;
            string querySql = "INSERT INTO \"public\".category(name_category, description, date_create, date_update)" +
                " VALUES (@namecategory, @description, @datecreate, @dateupdate)";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                using var command = conn.CreateCommand();
                command.CommandText = querySql;
                addParameters(command, category, false);
                conn.Open();
                var rowAffected = command.ExecuteNonQuery();
                result = rowAffected >= 1 ? "Registro Exitoso." : "Error al registrar Categoria.";
                return ValidationErrors.SuccesMessage(null, "Consulta exitosa de Categorias");
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

        public MessageResponse updateCategory(Category category)
        {
            string result;
            string querySql = "UPDATE \"public\".category cat SET " +
                "name_category=@namecategory, description=@description, date_update=@dateupdate" +
                " WHERE cat.idcategory = @idcategory";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                using var command = conn.CreateCommand();
                command.CommandText = querySql;
                addParameters(command, category, true);
                conn.Open();
                var rowAffected = command.ExecuteNonQuery();
                result = rowAffected >= 1 ? "Actualizacion Exitoso." : "Error al actualizar Categoria.";
                return ValidationErrors.SuccesMessage(null, "Actualizacion exitosa de Categorias");
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

        public MessageResponse deleteCategory(int idCategory)
        {
            string result;
            string querySql = "DELETE FROM \"public\".category cat WHERE cat.idcategory = @idcategory";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                using var command = conn.CreateCommand();
                command.CommandText = querySql;
                command.Parameters.AddWithValue("@idcategory", idCategory);
                conn.Open();
                var rowAffected = command.ExecuteNonQuery();
                result = rowAffected >= 1 ? "Eliminacion Exitoso." : "Error al Eliminar Categoria.";
                return ValidationErrors.SuccesMessage(null, "Eliminacion exitosa de Categorias");
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

        private void addParameters(NpgsqlCommand command, Category category, bool isUpdate)
        {
            var parameterCollection = command.Parameters;

            parameterCollection.AddWithValue("idcategory", category.idCategory);
            parameterCollection.AddWithValue("namecategory", category.nameCategory);
            parameterCollection.AddWithValue("description", category.descriptionCategory);
            parameterCollection.AddWithValue("datecreate", category.dateCreateCategory);
            parameterCollection.AddWithValue("dateupdate", category.dateUpdateCategory);
        }
    }
}
