using PaymentGetway.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PaymentGetway.BL
{
    public class StripePaymentBL
    {
        #region Singleton Design Pattern
        private static StripePaymentBL instance = null;
        public static StripePaymentBL GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StripePaymentBL();
                }
                return instance;
            }
        }
        private StripePaymentBL() { }
        #endregion
        public bool Insert_FreedomB_Payment(DataTable DTPaymentData)
        {
            return StripePaymentDL.GetInstance.Insert_FreedomB_Payment(DTPaymentData);
        }
    }
}