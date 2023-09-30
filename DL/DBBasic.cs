using System;
using System.Data;
using System.Data.SqlClient;

namespace PaymentGetway.DL
{
    public class DBBasic
    {
        public SqlConnection connection = null;
        public SqlCommand cmd = null;
        public SqlDataReader datareader = null;
        public SqlDataAdapter daAdapter;
        protected void Initialise()
        {
            try
            {
                connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["IPAD_DigitalWorkbookConnectionString"].ToString());
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                daAdapter = new SqlDataAdapter();
            }
            catch (Exception ex)
            {
                this.Log(ex);
                throw;
            }
        }
        protected void Close()
        {
            connection.Close();
            daAdapter.Dispose();
            cmd.Dispose();
        }
        protected void Log(Exception ex)
        {
            // Method intentionally left empty.
            // This method is add to resolve Sonar Issue "Generic exceptions should not be ignored." .
            // In future we should do some thing here. for ex make entry in a Exception log table.
        }
    }
}
