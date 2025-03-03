using LayerEntity.Inventory;
using LayerModel.Responses;
using Npgsql;
using System.Data;

namespace LayerData.Inventory.Impl
{
    public class AccessProduct : IProduct
    {

        public MessageResponse deleteProduct(int idProduct)
        {
            string result;
            string querySql = "DELETE FROM \"public\".product pt WHERE pt.idproduct = @idproduct";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                using var command = conn.CreateCommand();
                command.CommandText = querySql;
                command.Parameters.AddWithValue("@idproduct", idProduct);
                conn.Open();
                var rowAffected = command.ExecuteNonQuery();
                result = rowAffected >= 1 ? "Eliminacion Exitoso del producto." : "Error al querer eliminar el producto.";
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

        public MessageResponse getAllProduct()
        {
            NpgsqlDataReader result;
            NpgsqlConnection connection = new NpgsqlConnection();
            DataTable dataTable = new DataTable();

            try
            {
                connection = AccesDB.getInstance().createConection();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"public\".product;", connection);
                command.CommandType = CommandType.Text;
                connection.Open();
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
                if (connection.State.Equals(ConnectionState.Open)) connection.Close();
            }
        }

        public MessageResponse saveProduct(Product product)
        {
            string result;
            string querySql = "INSERT INTO public.product(name_product, \"minAmount\", description, date_create, date_update, code," +
                " \"unitMeasure\", \"priceBuy\", fk_idcategory, fk_idsupplier, amount, weight)" +
                "VALUES (@name_product, @minAmount, @description, @date_create, @date_update, @code, " +
                "@unitMeasure, @priceBuy, @fk_idcategory, @fk_idsupplier, @amount, @weight); RETURNING idproduct";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                NpgsqlCommand command = conn.CreateCommand();
                command.CommandText = querySql;
                addParameters(command, product);
                conn.Open();
                int productIdAdd = Convert.ToInt32(command.ExecuteScalar());
                result = productIdAdd > 0 ? "Registro Exitoso del Producto." : "Error al registrar Producto.";
                return ValidationErrors.SuccesMessage(null, result);
                //if (product.listaPrecios.Count != 0)
                //{
                //    result += savePriceDefault(product, productIdAdd);
                //}
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

        //private MessageResponse savePriceDefault(Product product, int idProduct)
        //{

        //    string result = "";  
        //    foreach (var listaDeprecio in product.listaPrecios)
        //    {
        //        listaDeprecio.idPriceList = 0;
        //        listaDeprecio.idProducto = idProduct;
        //        result = result + accessPrice.createPriceList(listaDeprecio);
        //    }

        //    return result;
        //}

        public MessageResponse updateProduct(Product product)
        {
            string result;
            string querySql = "UPDATE \"public\".product p SET " +
                "\"minAmount\"=@minAmount, description=@description, date_update=@date_update, code=@code," +
                " \"unitMeasure\"=@unitMeasure, \"priceBuy\"=@priceBuy, fk_idcategory=@fk_idcategory, fk_idsupplier=@fk_idsupplier, " +
                "amount=@amount, weight=@weight" +
                "WHERE p.idproduct = @idproduct";

            NpgsqlConnection conn = new NpgsqlConnection();
            conn = AccesDB.getInstance().createConection();

            try
            {
                using var command = conn.CreateCommand();
                command.CommandText = querySql;
                addParameters(command, product);
                conn.Open();
                var rowAffected = command.ExecuteNonQuery();
                result = rowAffected >= 1 ? "Actualizacion Exitosa del producto." : "Error al querer actualizar el producto.";
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

        private void addParameters(NpgsqlCommand command, Product product)
        {
            var parameterCollection = command.Parameters;
            parameterCollection.AddWithValue("idproduct", product.idProduct);
            parameterCollection.AddWithValue("name_product", product.nameProduct);
            parameterCollection.AddWithValue("minAmount", product.minAmount);
            parameterCollection.AddWithValue("description", product.descriptionProduct);
            parameterCollection.AddWithValue("date_create", product.dateCreate);
            parameterCollection.AddWithValue("date_update", product.dateUpdate);
            parameterCollection.AddWithValue("code", product.code);
            parameterCollection.AddWithValue("unidadMedida", product.unidadMedida);
            parameterCollection.AddWithValue("precioCompra", product.precioCompra);
            parameterCollection.AddWithValue("fk_idcategory", product.idCategoria);
            parameterCollection.AddWithValue("amount", product.amount);
            parameterCollection.AddWithValue("weight", product.weight);
           
        }
    }
}