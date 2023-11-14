using BusinessObject.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

        protected string GetConnectionString()
        {
            string appSettingsPath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "appsettings.json");

            var builder = new ConfigurationBuilder().AddJsonFile(appSettingsPath, optional: false);

            IConfiguration configuration = builder.Build();
            return configuration.GetConnectionString("DBDefault");
        }


        public void insertOrderProduct(OrderProduct orderProduct)
        {
            string connectionString = GetConnectionString();
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
            string connectionString = GetConnectionString();

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
            string connectionString = GetConnectionString();
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
        public class TopProduct
        {
            public string ProductName { get; set; }
            public int TotalQuantity { get; set; }
        }
        public IEnumerable<TopProduct> GetTopProduct(int month, int year)
        {
            var orderProducts = listOrderProducts()
                .Where(m => m.IdProductNavigation != null &&
                            m.IdOrderNavigation != null &&
                            m.IdOrderNavigation.DateBuy != null &&
                            m.IdOrderNavigation.DateBuy.Value.Month.Equals(month) &&
                            m.IdOrderNavigation.DateBuy.Value.Year.Equals(year))
                .GroupBy(m => m.IdProductNavigation?.Name)
                .Select(group => new TopProduct
                {
                    ProductName = group.FirstOrDefault()?.IdProductNavigation?.Name,
                    TotalQuantity = (int)(group == null ? 0 : group.Sum(m => m.Quantity))
                })
                .OrderByDescending(tp => tp.TotalQuantity)
                .Take(5);
            return orderProducts!;
        }
        public class TopTypeProduct
        {
            public string TypeProductName { get; set; }
            public int TotalQuantity { get; set; }
        }
        public  IEnumerable<TopTypeProduct> GetTopTypeProduct(int month, int year)
        {
            var orderProducts = listOrderProducts()
                .Where(m => m.IdOrderNavigation != null &&
                           m.IdOrderNavigation.DateBuy?.Month == month &&
                           m.IdOrderNavigation.DateBuy?.Year == year)
               .GroupBy(m => m.IdProductNavigation?.IdTypeProduct)
               .Select(group => new TopTypeProduct
               {
                   TypeProductName = group.FirstOrDefault()?.IdProductNavigation?.IdTypeProductNavigation?.Name,
                   TotalQuantity = (int)(group == null ? 0 : group.Sum(m => m.Quantity))
               })
               .OrderByDescending(tp => tp.TotalQuantity);

            return orderProducts;
        }
        public double GetTotalProductToSellByMonth(int month, int year)
        {
            var number = listOrderProducts().Where(m=>m.IdOrderNavigation != null &&
                           m.IdOrderNavigation.DateBuy?.Month == month &&
                           m.IdOrderNavigation.DateBuy?.Year == year).Sum(m=>m.Quantity);
            return (double)(number !=null?number:0);
        }
    }
}
