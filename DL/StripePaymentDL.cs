using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace PaymentGetway.DL
{
    public class StripePaymentDL : DBBasic
    {

        private StripePaymentDL()
           : base()
        { }

        private DataTable dt = null;
        private DataSet ds = null;

        #region Singleton Design Pattern
        private static StripePaymentDL instance = null;

        public static StripePaymentDL GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StripePaymentDL();
                }
                return instance;
            }
        }
        #endregion
        public  bool Insert_FreedomB_Payment(DataTable DTPaymentData)
        {
            try
            {
                this.Initialise();
                cmd.CommandText = "Insert_FreedomB_Payment";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = cmd.Parameters.AddWithValue("@PaymentData", DTPaymentData);
                parameter.SqlDbType = SqlDbType.Structured;
                parameter.TypeName = "dbo.MyDataTableType";
                connection.Open();
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                this.Log(ex);
                throw;
            }
            finally
            {

                this.Close();

            }
        }

    }
}