using LayerData.Inventory;
using LayerModel.Inventory;
using Npgsql;
using System.Data;

namespace LayerAccessData.Inventory.Impl
{
    public class AccessCategory : ICategory
    {
        public DataTable getAllCategory()
        {
            NpgsqlDataReader result;
            NpgsqlConnection conn = new NpgsqlConnection();
            DataTable dataTable = new DataTable();

            try
            {
                conn = AccesDB.getInstance().createConection();
                NpgsqlCommand command = new NpgsqlCommand("SELECT idcategory, name_category, description, date_create, date_update FROM \"salesUpInventory\".category;", conn);
                command.CommandType = CommandType.Text;
                conn.Open();
                result = command.ExecuteReader();
                dataTable.Load(result);
                return dataTable;
            }
            catch (NpgsqlException ex)
            {
                throw;
            }
            finally
            {
                if (conn.State.Equals(ConnectionState.Open)) conn.Close();
            }
        }

        public string createCategory(Category category)
        {
            string result;
            string querySql = "INSERT INTO \"salesUpInventory\".category(name_category, description, date_create, date_update)" +
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
            }
            catch (Exception ex)
            {
                result = "Error: \n" + ex.Message;
            }
            finally
            {
                if (conn.State.Equals(ConnectionState.Open)) conn.Close();
            }

            return result;
        }

        public string updateCategory(Category category)
        {
            string result;
            string querySql = "UPDATE \"salesUpInventory\".category cat SET " +
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
            }
            catch (Exception ex)
            {
                result = "Error: \n" + ex.Message;
            }
            finally
            {
                if (conn.State.Equals(ConnectionState.Open)) conn.Close();
            }

            return result;
        }

        public string deleteCategory(int idCategory)
        {
            string result;
            string querySql = "DELETE FROM \"salesUpInventory\".category cat WHERE cat.idcategory = @idcategory";

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
            }
            catch (Exception ex)
            {
                result = "Error: \n" + ex.Message;
            }
            finally
            {
                if (conn.State.Equals(ConnectionState.Open)) conn.Close();
            }

            return result;
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
