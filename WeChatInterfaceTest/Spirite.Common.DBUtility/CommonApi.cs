using Spirite.Common.DBUtility.HttpUtility;
using Spirite.Common.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spirite.Common.DBUtility
{
    public class CommonApi
    {
        /// <summary>
        /// 获取凭证接口
        /// </summary>
        /// <param name="appID">第三方用户唯一凭证</param>
        /// <param name="appsecret">第三方用户唯一凭证密钥，既appsecret</param>
        /// <param name="grant_type">获取access_token填写client_credential</param>
        /// <returns></returns>
        public static AccessTokenResultModel GetToken(string appID, string appsecret, string grant_type = "client_credential")
        {

            var url = string.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type={0}&appid={1}&secret={2}",
                                    grant_type, appID, appsecret);

            AccessTokenResultModel result = Get.GetJson<AccessTokenResultModel>(url);
            return result;
        }
    } 
}
