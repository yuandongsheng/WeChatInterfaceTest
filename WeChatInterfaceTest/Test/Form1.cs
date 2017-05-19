using Spirite.Common.DBUtility;
using Spirite.Common.DBUtility.HttpUtility;
using Spirite.Common.Model.JsonResult;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.Web.Script.Serialization;
using Spirite.Common.Model;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            #region 服务号

            #region 1、获取access_token

            //string appID = ConfigurationManager.AppSettings["appID"];
            //string appsecret = ConfigurationManager.AppSettings["appsecret"];
            //var access_Token = CommonApi.GetToken(appID, appsecret);

            #endregion

            //AccessTokenResultModel access_Token = new AccessTokenResultModel() { access_token = "Ag2tR1MK2n0FsdoZIzCzT9RbwCCWR6R4xy9Pq3qeXAUwXndwb9qZH1mESEEGuEEgfkwOs-gecpaDtmGEDpr6n9NNdF98A-KrKlaho95_Il5d6CPEn8zalPUjzZqk8xFAOSBjABAZDM", expires_in = 7200 };

            #region 2、获取微信服务器IP地址

            //string IPListURL = string.Format("https://api.weixin.qq.com/cgi-bin/getcallbackip?access_token={0}", access_Token.access_token);
            //var IPListResult = HttpGet(IPListURL);

            #endregion

            #region 3、报警排查指引

            #region 3.1、使用公众平台接口，获取到微信回调服务器的IP，https://api.weixin.qq.com/cgi-bin/getcallbackip?access_token=ACCESS_TOKEN

            //string getCallBackIPURL = string.Format("https://api.weixin.qq.com/cgi-bin/getcallbackip?access_token={0}", access_Token.access_token);
            //var callBackIP = HttpGet(getCallBackIPURL);

            #endregion

            #endregion

            #region 4、自定义菜单

            #region 4.1、自定义菜单创建接口

            //string createMenuStr = GetJsonStr(@"json\MunuJosn2.json");
            //string createMenuURL = string.Format("https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}", access_Token.access_token);
            //string createMenuResult = HttpPost(createMenuURL, createMenuStr);

            #endregion

            #region 4.2、自定义菜单查询接口

            //string getMenuURL = string.Format("https://api.weixin.qq.com/cgi-bin/menu/get?access_token={0}", access_Token.access_token);
            //string getMenuStr = HttpGet(getMenuURL);

            #endregion

            #region 4.3、自定义菜单删除接口

            //string delMenuURL = string.Format("https://api.weixin.qq.com/cgi-bin/menu/delete?access_token={0}", access_Token.access_token);
            //string delMenuStr = HttpGet(delMenuURL);

            #endregion

            #region 4.4、个性化菜单接口

            //string individuationMenuStr = GetJsonStr(@"json\individuationMenuStr.json");
            //string individuationMenuURL = string.Format("https://api.weixin.qq.com/cgi-bin/menu/addconditional?access_token={0}", access_Token.access_token);
            //string delMenuStr = HttpPost(individuationMenuURL, individuationMenuStr);

            #endregion


            #endregion

            #region 5、帐号管理

            #region 5.1、用户分组管理

            #region 5.1.1、创建分组

            //string createGroupStr = GetJsonStr(@"json\GroupStr.json");
            //string createGroupURL = string.Format("https://api.weixin.qq.com/cgi-bin/groups/create?access_token={0}", access_Token.access_token);
            //string createGroupResult = HttpPost(createGroupURL, createGroupStr);

            #endregion

            #region 5.1.2、查询所有分组

            //string getGroupURL = string.Format("https://api.weixin.qq.com/cgi-bin/groups/get?access_token={0}", access_Token.access_token);
            //string getGroupResult = HttpGet(getGroupURL);

            #endregion

            #region 5.1.3、查询用户所在分组

            //string userOpenID = GetJsonStr(@"json\UserInGroup.json");
            //string getUserGroupURL = string.Format("https://api.weixin.qq.com/cgi-bin/groups/getid?access_token={0}", access_Token.access_token);
            //string getGroupResult = HttpPost(getUserGroupURL, userOpenID);

            #endregion

            #region 5.1.4、修改分组名

            //string updateUserGroupStr = GetJsonStr(@"json\UpdateUserGroup.json");
            //string updateUserGroupURL = string.Format("https://api.weixin.qq.com/cgi-bin/groups/update?access_token={0}", access_Token.access_token);
            //string getGroupResult = HttpPost(updateUserGroupURL, updateUserGroupStr);

            #endregion

            #region 5.1.5、移动用户分组

            //string moveUserGroupStr = GetJsonStr(@"json\MoveUserGroup.json");
            //string moveUserGroupURL = string.Format("https://api.weixin.qq.com/cgi-bin/groups/members/update?access_token={0}", access_Token.access_token);
            //string moveUserGroupResult = HttpPost(moveUserGroupURL, moveUserGroupStr);

            #endregion

            #region 5.1.6、批量移动用户分组

            //string moveUserListGroupStr = GetJsonStr(@"json\MoveUserListGroup.json");
            //string moveUserLsitGroupURL = string.Format("https://api.weixin.qq.com/cgi-bin/groups/members/batchupdate?access_token={0}", access_Token.access_token);
            //string moveUserListGroupResult = HttpPost(moveUserLsitGroupURL, moveUserListGroupStr);

            #endregion

            #region 5.1.7、删除分组

            //string deleteGroupStr = GetJsonStr(@"json\DeleteGroup.json");
            //string deleteGroupURL = string.Format("https://api.weixin.qq.com/cgi-bin/groups/delete?access_token={0}", access_Token.access_token);
            //string deleteGroupResult = HttpPost(deleteGroupURL, deleteGroupStr);

            #endregion

            #endregion

            #region 5.2、设置备注名

            //string setBZStr = GetJsonStr(@"json\BZInfo.json");
            //string setBZURL = string.Format("https://api.weixin.qq.com/cgi-bin/user/info/updateremark?access_token={0}", access_Token.access_token);
            //string setBZResult = HttpPost(setBZURL, setBZStr);

            #endregion

            #region 5.3、获取用户基本信息(UnionID机制)

            #region 5.3.1、获取用户基本信息（包括UnionID机制）

            //string openid = string.Empty;
            //string getUserInfoURL = string.Format("https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}&lang=zh_CN", access_Token.access_token, openid);
            //string getUserInfoResult = HttpGet(getUserInfoURL);

            #endregion

            #region 5.3.2、批量获取用户基本信息

            //string getUserListInfoStr = GetJsonStr(@"json\GetUserInfo.json");
            //string getUserListInfoURL = string.Format("https://api.weixin.qq.com/cgi-bin/user/info/batchget?access_token={0}", access_Token.access_token);
            //string getUserListInfoResult = HttpPost(getUserListInfoURL, getUserListInfoStr);

            #endregion

            #endregion

            #region 5.4、获取用户列表

            //string nextOpenID = string.Empty;//第一个拉取的OPENID，不填默认从头开始拉取
            //string getUserListURL = string.Format("https://api.weixin.qq.com/cgi-bin/user/get?access_token={0}&next_openid={1}", access_Token.access_token, nextOpenID);
            //string getUserListInfoResult = HttpGet(getUserListURL);

            #endregion

            #endregion

            #region 6、帐号管理

            #region 6.1、生成带参数的二维码

            #region 6.1.1、临时二维码ticket

            //string linQRCodeStr = GetJsonStr(@"json\QRCode.json");
            //string linQRCodeURL = string.Format("https://api.weixin.qq.com/cgi-bin/qrcode/create?access_token={0}", access_Token.access_token);
            //string linQRCodeResult = HttpPost(linQRCodeURL, linQRCodeStr);

            #endregion

            #region 6.1.2、永久二维码ticket

            //POST数据例子：{"action_name": "QR_LIMIT_SCENE", "action_info": {"scene": {"scene_id": 123}}}
            //或者也可以使用以下POST数据创建字符串形式的二维码参数：
            //{"action_name": "QR_LIMIT_STR_SCENE", "action_info": {"scene": {"scene_str": "123"}}}

            //string yongQRCodeStr = GetJsonStr(@"json\yongQRCodeURLQRCode.json");
            //string yongQRCodeURL = string.Format("https://api.weixin.qq.com/cgi-bin/qrcode/create?access_token={0}", access_Token.access_token);
            //string yongQRCodeResult = HttpPost(yongQRCodeURL, yongQRCodeStr);

            #endregion

            #region 6.1.3、通过ticket换取二维码

            //string ticket = string.Empty;//二维码ticket
            //string ticketURL = string.Format("https://mp.weixin.qq.com/cgi-bin/showqrcode?ticket={0}", ticket);
            //string ticketResult = HttpGet(ticketURL);

            #endregion

            #endregion

            #region 6.2、长链接转短链接接口

            #endregion

            #endregion

            #region 待整理

            //string deptURL = string.Format("https://api.weixin.qq.com/cgi-bin/message/template/send?access_token={0}", access_Token.access_token);
            //string deptStr = GetJsonStr(@"json\pushInfo.json");
            //string re = HttpPost(deptURL, deptStr);

            //return;




            #region 2、创建菜单
            //string str = GetJsonStr(@"json\MunuJosn2.json");
            //CreateMenu(access_Token.access_token, str);

            #endregion


            //string url = string.Format("https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx4876eec0f93101c7&redirect_uri=http://106.14.29.73/Wechat/Index.aspx&response_type={0}&scope=snsapi_base&state=1#wechat_redirect", access_Token);
            //https://open.weixin.qq.com/connect/oauth2/authorize?appid=APPID&redirect_uri=REDIRECT_URI&response_type=code&scope=SCOPE&state=STATE#wechat_redirect



            //string result = HttpGet(url);
            //InfoWriteHelper.Write(result);

            //url = string.Format("https://api.weixin.qq.com/sns/userinfo?access_token={0}&openid=oRHgwxLTwm5Uq8rvUkv0IN8IBEI0&lang=zh_CN", access_Token);

            //result = HttpGet(url);
            //InfoWriteHelper.Write(result);

            //获取用户SingID
            //url = string.Format("https://api.weixin.qq.com/cgi-bin/user/get?access_token={0}&next_openid=", access_Token);
            //var useSingIDList = HttpGet(url);






            ////2.获取微信服务器IP地址
            //var urlIPList = "https://api.weixin.qq.com/cgi-bin/getcallbackip?access_token={0}";
            //var urlFrom = string.Format(urlIPList, access_Token.access_token);
            //var weChatIPList = Spirite.Common.DBUtility.HttpUtility.RequestUtility.HttpGet(urlFrom, null);

            ////3.修改菜单信息
            //url = "https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}";
            //urlFrom = string.Format(url, access_Token.access_token);
            //var Menejson = "{\"button\":[{\"sub_button\":[{\"key\":\"1.1\",\"type\":\"pic_photo_or_album\",\"name\":\"第一列1\"},{\"key\":\"1.2\",\"type\":\"click\",\"name\":\"第一列2\"},{\"key\":\"1.3\",\"type\":\"click\",\"name\":\"第一列3\"},{\"key\":\"1.4\",\"type\":\"click\",\"name\":\"第一列4\"},{\"key\":\"1.5\",\"type\":\"click\",\"name\":\"第一列5\"}],\"name\":\"第一列\"},{\"sub_button\":[{\"key\":\"2.1\",\"type\":\"click\",\"name\":\"第二列1\"},{\"key\":\"2.2\",\"type\":\"click\",\"name\":\"第二列2\"},{\"key\":\"2.3\",\"type\":\"click\",\"name\":\"第二列3\"},{\"key\":\"2.4\",\"type\":\"click\",\"name\":\"第二列4\"},{\"key\":\"2.5\",\"type\":\"click\",\"name\":\"第二列5\"}],\"name\":\"第二列\"},{\"sub_button\":[{\"key\":\"3.1\",\"type\":\"click\",\"name\":\"第三列1\"},{\"key\":\"3.2\",\"type\":\"click\",\"name\":\"第三列2\"},{\"key\":\"3.3\",\"type\":\"click\",\"name\":\"第三列3\"},{\"key\":\"3.4\",\"type\":\"click\",\"name\":\"第三列4\"},{\"key\":\"3.5\",\"type\":\"click\",\"name\":\"第三列5\"}],\"name\":\"第三列\"}]}";
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    var bytes = Encoding.UTF8.GetBytes(Menejson);
            //    ms.Write(bytes, 0, bytes.Length);
            //    ms.Seek(0, SeekOrigin.Begin);
            //    WxJsonResultModel ss = Post.PostGetJson<WxJsonResultModel>(urlFrom, null, ms);
            //}



            ////4.获取菜单信息
            //url = "https://api.weixin.qq.com/cgi-bin/get_current_selfmenu_info?access_token={0}";
            //urlFrom = string.Format(url, access_Token.access_token);
            //var menuList = Spirite.Common.DBUtility.HttpUtility.RequestUtility.HttpGet(urlFrom, null);

            //验证消息的正确性
            //string signature = "a948c4f99d23c1b6ef78204c1eb867166e2276e8";//context.Request.QueryString["signature"];
            //string timestamp = "1405665299";//context.Request.QueryString["timestamp"];
            //string nonce = "42752994";//context.Request.QueryString["nonce"];
            //string token = access_Token.ToString();

            //List<string> list = new List<string>();
            //list.Add(token);
            //list.Add(timestamp);
            //list.Add(nonce);
            //list.Sort();

            //list.Sort();

            //string res = string.Join("", list.ToArray());


            //Byte[] data1ToHash = Encoding.ASCII.GetBytes(res);
            //byte[] hashvalue1 = ((HashAlgorithm)CryptoConfig.CreateFromName("SHA1")).ComputeHash(data1ToHash);

            //StringBuilder sb = new StringBuilder();
            //foreach (byte b in hashvalue1)
            //{
            //    sb.Append(b.ToString("x2"));
            //}
            ////string s = BitConverter.ToString(hashvalue1).Replace("-", string.Empty).ToLower();
            //if (signature == sb.ToString())
            //{
            //    Console.Write("OK");
            //}
            //else
            //{
            //    Console.Write("NO");
            //}

            //string appID = "wx4876eec0f93101c7";
            //string appsecret = "06ee27062d17c764ab2715ba8b2e8006";
            //获取token
            //AccessTokenResultModel model = GetTokenModel(appID, appsecret);

            //菜单管理
            string jsonPath = @"E:\微信开发框架\微信框架_spirite\Spirite_接口测试\Spirite\Test\json\MunuJosn2.json";
            //CreateMenu(access_Token, jsonPath);

            //分组管理
            //CreateGroup(model.access_token);
            //RemarkName(model.access_token);
            //GetUserInfo(model.access_token);

            //账号管理
            //二维码
            //CreateQRCode(model.access_token);
            //长连接转短链接
            //ShorTurl(model.access_token);

            #endregion

            #endregion


            #region 企业号

            #region 1、获取AccessToken

            string CorpID = ConfigurationManager.AppSettings["CorpID"];
            string Secret = ConfigurationManager.AppSettings["Secret"];

            //string tokenUrl = string.Format("https://qyapi.weixin.qq.com/cgi-bin/gettoken?corpid={0}&corpsecret={1}", CorpID, Secret);
            //AccessTokenResultModel tokenStr = Get.GetJson<AccessTokenResultModel>(tokenUrl);

            #endregion

            AccessTokenResultModel tokenStr = new AccessTokenResultModel { access_token = "hawa-OY7KKKRMuBiqBgcQ-JK9Wq0-dwDMX1g-Fap8Ao9pad-s-PdS_NwIwq23GQT", expires_in = 7200 };

            #region 2、身份验证

            #region 2.1、OAuth验证接口

            #region 2.1.1、企业获取code

            string redirectURL = "http://spirite.cn/";
            string getCodeURL = string.Format(@"https://open.weixin.qq.com/connect/oauth2/authorize?appid={0}&
                                            redirect_uri={1}&response_type=code&scope={2}&agentid={3}&state=STATE#wechat_redirect", CorpID, redirectURL, ScopeTypeModel.snsapi_base, 8);
            var resultCode = HttpGet(getCodeURL);

           
            #endregion

            #region 2.1.1、根据code获取成员信息

            string peopleCodeURL = string.Format("https://qyapi.weixin.qq.com/cgi-bin/user/getuserinfo?access_token={0}&code={1}", tokenStr.access_token, 8);
            var peopleCodeResult = HttpGet(peopleCodeURL);

            #endregion

            #endregion

            return;
            #endregion

            //创建部门
            //string deptURL = string.Format("https://qyapi.weixin.qq.com/cgi-bin/department/create?access_token={0}", tokenStr.access_token);
            //string deptStr = GetJsonStr(@"json\newdept.json");
            //string re = HttpPost(deptURL, deptStr);

            //获取所有部门
            //string deptAllURL = string.Format("https://qyapi.weixin.qq.com/cgi-bin/department/list?access_token={0}&id=1", tokenStr.access_token);
            //string deptAllStr = HttpGet(deptAllURL);

            //更新部门
            //string deptUpateURL = string.Format("https://qyapi.weixin.qq.com/cgi-bin/department/update?access_token={0}", tokenStr.access_token);
            //string deptUpateStr = GetJsonStr(@"json\updatedept.json");
            //string res44 = HttpPost(deptUpateURL, deptUpateStr);
            //return;


            #endregion
        }

        //private bool CreateMenu()
        //{
        //    var urlFormat = "https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}";
        //    return false;
        //}

        #region 获取token

        /// <summary>
        /// 获取token
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="appSecret"></param>
        /// <returns></returns>
        public AccessTokenResultModel GetTokenModel(string appID, string appSecret)
        {
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}", appID, appSecret);
            string result = HttpGet(url);
            JavaScriptSerializer js = new JavaScriptSerializer();
            AccessTokenResultModel model = js.Deserialize<AccessTokenResultModel>(result);
            return model;
        }

        #endregion

        #region 菜单管理

        /// <summary>
        /// 菜单创建
        /// </summary>
        /// <param name="token"></param>
        public void CreateMenu(string token, string jsonPath)
        {
            string result = HttpPost("https://api.weixin.qq.com/cgi-bin/menu/create?access_token=" + token, jsonPath);
        }

        #endregion

        #region 分组管理

        /// <summary>
        /// 创建分组
        /// </summary>
        /// <param name="token"></param>
        public void CreateGroup(string token)
        {
            string groupJson = "{\"group\":{ \"id\": 107, \"name\":\"tydic\"}}";
            string result = HttpPost("https://api.weixin.qq.com/cgi-bin/groups/create?access_token=" + token, groupJson);
        }

        /// <summary>
        /// 修改备注
        /// </summary>
        /// <param name="token"></param>
        public void RemarkName(string token)
        {
            string remarJson = "{\"openid\":\"oRHgwxDyMeDPpOgumkbdleRVStoM\",\"remark\":\"王俊\"}";
            string result = HttpPost("https://api.weixin.qq.com/cgi-bin/user/info/updateremark?access_token=" + token, remarJson);
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="token"></param>
        public void GetUserInfo(string token)
        {
            string result = HttpGet("https://api.weixin.qq.com/cgi-bin/user/info?access_token=" + token + "&openid=oRHgwxDyMeDPpOgumkbdleRVStoM&lang=zh_CN");
        }

        #endregion

        #region 账号管理

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="token"></param>
        public QRCode CreateQRCode(string token)
        {
            //expire_seconds:该二维码有效时间，以秒为单位。 最大不超过604800（即7天）。
            //action_name:二维码类型，QR_SCENE为临时,QR_LIMIT_SCENE为永久,QR_LIMIT_STR_SCENE为永久的字符串参数值
            //action_info:二维码详细信息
            //scene_id:场景值ID，临时二维码时为32位非0整型，永久二维码时最大值为100000（目前参数只支持1--100000）
            //scene_str:场景值ID（字符串形式的ID），字符串类型，长度限制为1到64，仅永久二维码支持此字段

            //临时二维码Json
            string QRCodeJson = "{\"expire_seconds\": 604800, \"action_name\": \"QR_SCENE\", \"action_info\": {\"scene\": {\"scene_id\": 123}}}";
            //永久二维码Json
            string QRLimtStrSceneJson = "{\"action_name\": \"QR_LIMIT_SCENE\", \"action_info\": {\"scene\": {\"scene_id\": 123}}}";
            string result = HttpPost("https://api.weixin.qq.com/cgi-bin/qrcode/create?access_token=" + token, QRLimtStrSceneJson);

            JavaScriptSerializer js = new JavaScriptSerializer();
            QRCode model = js.Deserialize<QRCode>(result);
            //打印二维码
            //Response.Redirect("https://mp.weixin.qq.com/cgi-bin/showqrcode?ticket=" + model.ticket);
            return model;
        }

        public class QRCode
        {
            /// <summary>
            /// 获取的二维码ticket，凭借此ticket可以在有效时间内换取二维码。
            /// </summary>
            public string ticket { get; set; }
            /// <summary>
            /// 该二维码有效时间，以秒为单位。 最大不超过604800（即7天）。
            /// </summary>
            public string expire_seconds { get; set; }
            /// <summary>
            /// 二维码图片解析后的地址，开发者可根据该地址自行生成需要的二维码图片
            /// </summary>
            public string url { get; set; }
        }

        /// <summary>
        /// 长链接转短链接接口
        /// </summary>
        /// <param name="token"></param>
        public string ShorTurl(string token)
        {
            QRCode code = CreateQRCode(token);
            ///access_token  调用接口凭证
            //action         此处填long2short，代表长链接转短链接
            //long_url       需要转换的长链接，支持http://、https://、weixin://wxpay 格式的url
            string LongUrlJson = "{\"action\":\"long2short\",\"long_url\":\"" + code.url + "\"}";
            string result = HttpPost("https://api.weixin.qq.com/cgi-bin/shorturl?access_token=" + token, LongUrlJson);
            JavaScriptSerializer js = new JavaScriptSerializer();
            ShorTrul model = js.Deserialize<ShorTrul>(result);
            return model.short_url;
        }

        public class ShorTrul
        {
            /// <summary>
            /// 错误码
            /// </summary>
            public string errcode { get; set; }
            /// <summary>
            /// 错误信息
            /// </summary>
            public string errmsg { get; set; }
            /// <summary>
            /// 短链接
            /// </summary>
            public string short_url { get; set; }
        }

        #endregion

        #region 素材管理

        /// <summary>
        /// 上传临时素材
        /// </summary>
        /// <param name="token"></param>
        public void Upload(string token)
        {
            string imageJson = "";
            //access_token 调用接口凭证
            //type         媒体文件类型，分别有图片（image）、语音（voice）、视频（video）和缩略图（thumb）
            //media        form-data中媒体文件标识，有filename、filelength、content-type等信息
            string result = HttpPost("https://api.weixin.qq.com/cgi-bin/media/upload?access_token=" + token + "&type=image", imageJson);

            WebClient wx_upload = new WebClient();
            string filename = @"C\:hello.jpg";//在IE浏览器里可以取到物理路径，但是在别的浏览器中无法获取物理路径


            //string imagename = Uploadimage(filename);
            //byte[] imageArr = wx_upload.UploadFile(new Uri(String.Format("http://file.api.weixin.qq.com/cgi-bin/media/upload?access_token={0}&type={1}", Function.GetAccessToken(), "image")), filename);
            //string resultjson = Encoding.Default.GetString(imageArr);//在这里获取json数据，以获取media_id


        }




        #endregion

        #region Model模型

        /// <summary>
        /// token模型
        /// </summary>
        public class AccessTokenResultModel
        {
            /// <summary>
            /// 获取到的凭证
            /// </summary>
            public string access_token { get; set; }

            /// <summary>
            /// 凭证有效时间，单位：秒
            /// </summary>
            public int expires_in { get; set; }
        }

        public enum ScopeTypeModel
        {
            snsapi_base, snsapi_userinfo
        }

        #endregion

        #region 公共方法

        /// <summary>
        /// 获取GET请求结果
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string HttpGet(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        /// <summary>
        /// 获取POST请求结果
        /// </summary>
        /// <param name="posturl"></param>
        /// <param name="postData"></param>
        /// <returns></returns>
        public static string HttpPost(string posturl, string postData)
        {
            Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            Encoding encoding = Encoding.UTF8;
            byte[] data = encoding.GetBytes(postData);
            // 准备请求...
            try
            {
                // 设置参数
                request = WebRequest.Create(posturl) as HttpWebRequest;
                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                outstream = request.GetRequestStream();
                outstream.Write(data, 0, data.Length);
                outstream.Close();
                //发送请求并获取相应回应数据
                response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                instream = response.GetResponseStream();
                sr = new StreamReader(instream, encoding);
                //返回结果网页（html）代码
                string content = sr.ReadToEnd();
                string err = string.Empty;
                return content;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return string.Empty;
            }
        }

        #endregion

        #region 读取json文件

        public string GetJsonStr(string path)
        {
            string fullpath = AppDomain.CurrentDomain.BaseDirectory + path;
            //fullpath=Application.StartupPath;
            //fullpath = Application.UserAppDataPath;
            //fullpath = Environment.CurrentDirectory;
            //fullpath = HttpRuntime.AppDomainAppPath.ToString();


            StreamReader sr = File.OpenText(fullpath);
            StringBuilder str = new StringBuilder();
            string input = string.Empty;
            while ((input = sr.ReadLine()) != null)
            {
                str.Append(input);
            }
            return str.ToString();
        }

        #endregion
    }
}
