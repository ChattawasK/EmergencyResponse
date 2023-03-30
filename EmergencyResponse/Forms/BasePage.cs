using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmergencyResponseForms
{
    public class BasePage : System.Web.UI.Page
    {
        virtual protected void PageLoadEvent(object sender, System.EventArgs e)
        { }
        protected void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();

            // Do something with the exception e.g. log it

            Server.Transfer("~/ErrorPage.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        #region Web Form Designer generated code
        override protected void OnInit(EventArgs e)
        {
            //
            //
            // CODEGEN: This call is required by the ASP.NET Web Form Designer.
            //
            InitializeComponent();
            base.OnInit(e);
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Load += new System.EventHandler(this.Page_Load);
        }
        #endregion
    }
}