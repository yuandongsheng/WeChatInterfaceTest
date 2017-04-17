using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spirite.Common.Model.JsonResult;

namespace Spirite.Common.DBUtility.Exceptions
{
    /// <summary>
    /// JSON返回错误代码（比如token_access相关操作中使用）。
    /// </summary>
    public class ErrorJsonResultException : WeixinException
    {
        public WxJsonResultModel JsonResult { get; set; }
        public ErrorJsonResultException(string message, Exception inner, WxJsonResultModel jsonResult)
            : base(message, inner)
        {
            JsonResult = jsonResult;
        }
    }
}
