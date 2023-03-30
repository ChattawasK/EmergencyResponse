using System;
using System.Data;
using System.Data.SqlClient;

namespace EmergencyResponseDataClass
{
    public class BaseDataContext
    {
        #region "Database access"
        public static String _dbString;
        private static readonly int DefaultTimeOut;
        public static string connectStringName = System.Configuration.ConfigurationManager.ConnectionStrings["Dbconnection"].ToString();
        #endregion

        static BaseDataContext()
        {
            string sTimeOut;
            try
            {
                sTimeOut = System.Configuration.ConfigurationManager.AppSettings["DefaultTimeOut"].ToString();
            }
            catch
            {
                sTimeOut = "0";
            }
            if (!string.IsNullOrEmpty(sTimeOut) && int.TryParse(sTimeOut, out int n))
                DefaultTimeOut = n;
            else
                DefaultTimeOut = 0;

           
        }

        public class Configs
        {

            public static System.Data.SqlClient.SqlConnection CreateConnection()
            {
                _dbString = Configs.GetConnectionString();
                return new System.Data.SqlClient.SqlConnection(_dbString);
            }

            public static String GetConnectionString()
            {
                string dbString = string.Empty;
                try
                {

                    if (!String.IsNullOrWhiteSpace(connectStringName))
                    {
                        dbString = System.Configuration.ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return dbString;
            }

          

        }
        public DataTable SelConfigTradeDate(string date)
        {
            DataSet _ret = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection _conn = Configs.CreateConnection())
                {
                    if (_conn.State != ConnectionState.Open)
                    {
                        _conn.Open();
                    }
                    SqlCommand _command = new System.Data.SqlClient.SqlCommand();
                    _command.Connection = _conn;
                    _command.CommandTimeout = 0;
                    _command.CommandType = System.Data.CommandType.StoredProcedure;
                    _command.CommandText = "GMX_TRDETREP_Sel_ConfigTradeDate_P";
                    _command.Parameters.AddWithValue("@AsOfDate", date);
                    SqlDataAdapter _adap = new SqlDataAdapter(_command);
                    _adap.Fill(_ret);
                    if (_ret.Tables.Count > 0)
                    {
                        dt = _ret.Tables[0];
                        //if (_ret.Tables[0] != null && _ret.Tables[0].Rows.Count > 0)
                        //{
                        //    TrdetrepDate = _ret.Tables[0].Rows[0]["TrdetrepDate"].ToString();
                        //}


                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        public DataTable SelTable()
        {

            DataSet _ret = new DataSet();
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection _conn = Configs.CreateConnection())
                {
                    if (_conn.State != ConnectionState.Open)
                    {
                        _conn.Open();
                    }
                    SqlCommand _command = new System.Data.SqlClient.SqlCommand("Select * from [T_USER]");
                    _command.Connection = _conn;
                    _command.CommandTimeout = 0;
                    SqlDataAdapter _adap = new SqlDataAdapter(_command);
                    _adap.Fill(_ret);
                    if (_ret.Tables.Count > 0)
                    {
                        dt = _ret.Tables[0];


                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

    } 
}
