using BusinessObject.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HRMDAO
{
    public class OrderProductDAO
    {
        private static OrderProductDAO instance = null;
        private OrderProductDAO() { }

        public static OrderProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderProductDAO();
                }
                return instance;
            }
        }
        public List<OrderProduct> listOrderProducts()
        {
            using var db = new CAGE_SHOPContext();
            var temp = db.OrderProducts.Include(c => c.IdOrderNavigation).Include(c => c.IdProductNavigation).ToList();
            return temp;
        }
        public List<OrderProduct> listOrderProductsByidOrder(string idOrder)
        {
            using var db = new CAGE_SHOPContext();

            var temp = db.OrderProducts
                .Include(c => c.IdOrderNavigation)
                .Include(c => c.IdProductNavigation)
                .Where(op => op.IdOrder == idOrder)  
                .ToList();

            return temp;
        }
        public void insertOrderProduct(OrderProduct orderProduct)
        {
            string connectionString = "Server=DESKTOP-R23TMQS\\ALEX;Database=CAGE_SHOP;Trusted_Connection=True; TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    string sqlInsert = "INSERT INTO Order_Product (idProduct, idOrder, discount, quantity, price, total) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";
                    command.CommandText = sqlInsert;
                    command.Parameters.Add(new SqlParameter("@Value1", orderProduct.IdProduct));
                    command.Parameters.Add(new SqlParameter("@Value2", orderProduct.IdOrder));
                    command.Parameters.Add(new SqlParameter("@Value3", orderProduct.Discount));
                    command.Parameters.Add(new SqlParameter("@Value4", orderProduct.Quantity));
                    command.Parameters.Add(new SqlParameter("@Value5", orderProduct.Price));
                    command.Parameters.Add(new SqlParameter("@Value6", orderProduct.Total));
                    command.ExecuteNonQuery();
                }
            }
            return;
        }
        public List<OrderProduct> listOrderProductsToCancel(string idOrder)
        {
            using var db = new CAGE_SHOPContext();
            var orderProducts = db.OrderProducts
                .Where(m => m.IdOrder == idOrder)
                .Select(m => new OrderProduct
                {
                    IdProduct = m.IdProduct,
                    Quantity = m.Quantity
                })
                .ToList();

            return orderProducts;
        }
        public void deleteOrderProduct(string idOrder)
        {
            string connectionString = "Server=DESKTOP-R23TMQS\\ALEX;Database=CAGE_SHOP;Trusted_Connection=True; TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        string sqlDelete = "DELETE FROM Order_Product WHERE idOrder = @idOrder";
                        command.CommandText = sqlDelete;
                        command.Parameters.Add(new SqlParameter("@idOrder", idOrder));
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                    throw; 
                }
            }
        }
        public void deleteOrderProductByIdOrderAndIdProduct(string idOrder, string idProduct)
        {
            string connectionString = "Server=DESKTOP-R23TMQS\\ALEX;Database=CAGE_SHOP;Trusted_Connection=True; TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    string sqlDelete = "DELETE FROM Order_Product WHERE idProduct = @idProduct AND idOrder = @idOrder";
                    command.CommandText = sqlDelete;
                    command.Parameters.Add(new SqlParameter("@idProduct", idProduct));
                    command.Parameters.Add(new SqlParameter("@idOrder", idOrder));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
