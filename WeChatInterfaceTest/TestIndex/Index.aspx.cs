using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestIndex
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string signature = HttpContext.Current.Request["signature"];
            //string signature = Request.QueryString["signature"].ToString();
            //string timestamp = Request.QueryString["timestamp"].ToString();
            //string nonce = Request.QueryString["nonce"].ToString();
        }
    }
}