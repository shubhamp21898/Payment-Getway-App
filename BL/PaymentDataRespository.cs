using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PaymentGetway.Models;

namespace PaymentGetway.BL
{
    public class PaymentDataRepository
    {
        private string connectionString;

        public PaymentDataRepository()
        {
            // Retrieve the connection string from web.config
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        public  void InsertPaymentData(PaymentData paymentData)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO Test ([id], [country]) VALUES (@id, @Country)";

                    command.Parameters.AddWithValue("@id", paymentData.AccountId);
                    command.Parameters.AddWithValue("@Country", "Ind");

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
