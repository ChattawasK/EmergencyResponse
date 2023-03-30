using EmergencyResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmergencyResponse.Forms
{
    public partial class FrmQuestionRespone_aspx : System.Web.UI.Page
    {
        protected ResponseAnswerClass res;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                ExcemDetail ex_detail = new ExcemDetail();
                res = ex_detail.GetResponseAnswer();
                var match = res.Excems.Count(w => w.IsCorrect.Contains("1"));
                txtScroe.InnerText = match.ToString() + "/" + res.Excems.Count.ToString();
                var vendorCode = Session["VendorCode"] != null ? Session["VendorCode"].ToString() : "";

                if (String.IsNullOrEmpty(vendorCode))
                {
                    Response.Redirect("FrmQuestion.aspx");
                }

            }

        }
    }
}