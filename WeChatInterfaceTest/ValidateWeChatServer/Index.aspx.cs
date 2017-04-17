using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidateWeChatServer
{
    public partial class Index : System.Web.UI.Page
    {
        public string Token = "tydic";
        public string echoStr = "zaAonrtZu9GQuyj5c9uPOILIrFmCcLEpXVd3aeTpufR";
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(Request.QueryString["echoStr"])) { Response.End(); }

            //string echoStr = Request.QueryString["echoStr"].ToString();

            if (CheckSignature())
            {
                if (!string.IsNullOrEmpty(echoStr))
                {
                    Response.Write(echoStr);
                    Response.End();
                }
            }
        }

        private bool CheckSignature()
        {
            string signature = Request.QueryString["signature"].ToString();
            string timestamp = Request.QueryString["timestamp"].ToString();
            string nonce = Request.QueryString["nonce"].ToString();
            string[] ArrTmp = { Token, timestamp, nonce };
            Array.Sort(ArrTmp);　　 //字典排序  
            string tmpStr = string.Join("", ArrTmp);
            tmpStr = FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");
            tmpStr = tmpStr.ToLower();
            if (tmpStr == signature)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}