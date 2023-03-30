using EmergencyResponseDataClass;
using EmergencyResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmergencyResponse.Forms
{
    public partial class FrmQuestion : System.Web.UI.Page
    {
        protected IList<ExcemClass> listLEcems;
        #region "Static Object"
        private static BaseDataContext ObjectDataClass = new BaseDataContext();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ExcemDetail ex_detail = new ExcemDetail();
                listLEcems = ex_detail.GetExcemDetail();
                var vendorCode = Session["VendorCode"] != null ? Session["VendorCode"].ToString() : "";

                if (!String.IsNullOrEmpty(vendorCode))
                {
                    Session.Remove("VendorCode");
                }

                //var a = ObjectDataClass.SelTable();
            }

        }



        [System.Web.Services.WebMethod(EnableSession = true)]
        [System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
        public static Object OnChcekScore(string phone)
        {
            try
            {
                //query Phone

                HttpContext.Current.Session["VendorCode"] = "VendorCode";
                return new { resStatus = true, resMessage = "", data = "" };
            }
            catch (Exception ex)
            {
                return new { resStatus = false, resMessage = string.Format("OnChcekScore - {0}", ex.Message), data = "" };
            }

        }

        [System.Web.Services.WebMethod(EnableSession = true)]
        [System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
        public static Object OnSaveFrom(ResponseAnswerClass res)
        {
            try
            {
                //query Phone
                return new { resStatus = true, resMessage = "", data = res.Phone };
            }
            catch (Exception ex)
            {
                return new { resStatus = false, resMessage = string.Format("OnChcekScore - {0}", ex.Message), data = "" };
            }

        }
    }
}