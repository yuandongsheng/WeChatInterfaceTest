using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spirite.Common.Model
{
    public class CreateMenuResultModel
    {
        //{"errcode":0,"errmsg":"ok"}

        /// <summary>
        /// 创建菜单结果编号
        /// </summary>
        public string errcode { get; set; }

        /// <summary>
        /// 创建菜单结果信息
        /// </summary>
        public int errmsg { get; set; }
    }
}
