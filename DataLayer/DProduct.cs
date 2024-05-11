using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DProduct
    {
        public List<Product> getProducts()
        {

            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                SqlCommand command = new SqlCommand("sp_GetProducts", conn);
                command.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.product_id = Convert.ToInt32(reader["product_id"]);
                    product.name = reader.GetString("name");
                    product.price = reader.GetDecimal("price");
                    product.stock = reader.GetInt32("stock");
                    product.active = reader.GetBoolean("active");
                    products.Add(product);
                }
            }
            return products;

        }

        public void insertProduct()
        {
        }

        public void deleteProduct() {

        }
        public void updateProduct() {

        }

    }
}
