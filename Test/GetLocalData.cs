using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class GetLocalData
    {
        //string path = @"JsonTest\GetFwBaseInfoList.json";
        public static string GetJsonStr(string path)
        {
            string fullpath = AppDomain.CurrentDomain.BaseDirectory + path;
            StreamReader sr = File.OpenText(fullpath);
            StringBuilder str = new StringBuilder();
            string input = string.Empty;
            while ((input = sr.ReadLine()) != null)
            {
                str.Append(input);
            }
            return str.ToString();
        }
    }

}
