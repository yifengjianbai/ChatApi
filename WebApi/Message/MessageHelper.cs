using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace WebApi
{
    /// <summary>
    /// 短信帮助类
    /// </summary>
    public static class MessageHelper
    {
        private static string API_Key = "495a5106630b8814331d670efa85288e";

        private static string url = "http://api01.monyun.cn:7901/sms/v2/std/";

        private static string Account_Number = "E10A5H";

        private static string PassWord = "o6zMfD";

        /// <summary>
        /// 单发
        /// </summary>
        /// <param name="Phone">手机号</param>
        /// <param name="code">验证码</param>
        /// <param name="custid">用户自定义流水号</param>
        /// <param name="time">有效时间</param>
        /// <returns></returns>
        public static string SendCode(string Phone, string code, string custid, string time)
        {
            string timestamp = DateTime.Now.ToString("MMddHHmmss");
            var data = Account_Number.ToUpper() + "00000000" + PassWord + timestamp;
            var config = MD5Hash(data);
            string src = (DateTime.Now).ToString();
            PhoneMessage msg = new PhoneMessage();
            msg.Mobile = Phone;
            msg.Content = string.Format("您的验证码是'{0}'，在'{1}'分钟内输入有效。如非本人操作请忽略此短信。", code, time);
            msg.ExNo = "";
            msg.CustId = custid;
            msg.ExData = "";
            msg.SvrType = "";
            msg.Pwd = config;
            msg.TimeStamp = timestamp;
            return submit(msg, 1);
        }


        /// <summary>
        /// 统一提交
        /// </summary>
        /// <param name="message">请求对象</param>
        /// <param name="sendtype">请求类型,1:单发，2：相同内容群发，3：不同类型群发，4：获取上行，5：获取状态报告，6：获取账号余额</param>
        /// <returns></returns>
        public static string submit(PhoneMessage message, int sendtype)
        {
            try
            {
                ISMS sms = null;
                sms = new UrlEncdoeSend();
                String ipport = "api01.monyun.cn:7901";
                return sms.execute(message, sendtype, ipport, 1, true);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// HTTP提交
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="contents"></param>
        /// <param name="bKeepAlive"></param>
        /// <returns></returns>
        public static string httpPost(string contents, string uri, bool bKeepAlive)
        {
            //创建一个Http请求
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            //设置请求的方法。
            request.Method = "POST";
            //设置 Content-typeHTTP 标头的值。 
            request.ContentType = "application/json";

            //请求所包含的 Connection HTTP 标头带有 Keep-alive 这一值，则为 true；否则为 false。默认值为  true。
            request.KeepAlive = bKeepAlive;
            //转为UTF-8
            byte[] bytes = Encoding.GetEncoding("utf-8").GetBytes(contents);
            //设置 Content-lengthHTTP 标头。
            request.ContentLength = bytes.Length;
            // 获取用于写入请求数据的 System.IO.Stream 对象。
            Stream os = request.GetRequestStream();
            os.Write(bytes, 0, bytes.Length);
            os.Close();
            //提供来自统一资源标识符 (URI) 的响应       
            System.Net.WebResponse response = request.GetResponse();
            if (response == null)
                return String.Empty;

            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                //从流的当前位置到末尾读取流。
                return sr.ReadToEnd().Trim();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string MD5Hash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
                var strResult = BitConverter.ToString(result);
                return strResult.Replace("-", "");
            }
        }
    }
}
