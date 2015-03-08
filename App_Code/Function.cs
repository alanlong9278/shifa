/*
 * 程序由闫海港编写
 * 
 * 交流博客：http://blog.sina.com.cn/piaoranshijie
 */
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;

/// <summary>
///Functions类是系统常用的功能类，实现了常见字符的编码解码、登陆密码的加密和解密、字符串的取反等
/// </summary>
    public class Functions
    {
        public Functions()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }
        public static string Encode(string str)
        {
            //string类的Replace方法的功能是将此实例中的指定的Unicode字符
            //或String的所有匹配项替换为其他指定的Unicode字符或者string
            str = str.Replace("&", "&amp;");
            str = str.Replace("'", "''");
            str = str.Replace("\"", "&quot;");
            str = str.Replace(" ", "&nbsp;");
            str = str.Replace("<", "&lt;");
            str = str.Replace(">", "&gt;");
            str = str.Replace("\n", "<br />");
            return str;
        }
        public static string Delete(string str)
        {
            str = str.Replace("<p>", " ");
            str = str.Replace("</p>", " ");
            return str;
        }
        public static string Decode(string str)
        {
            str = str.Replace("<br />", "\n");
            str = str.Replace("<br>", "\n");
            str = str.Replace("&gt;", ">");
            str = str.Replace("&lt;", "<");
            str = str.Replace("&nbsp;", " ");
            str = str.Replace("&quot;", "\"");
            str = str.Replace("''", "'");
            str = str.Replace("&amp;", "&");
            return str;
        }
        public static string Encrypt(string Password, int Format)
        {
            string str = "";
            switch (Format)
            {
                //如果Format的值为0，采用SHA1的方式加密
                case 0:
                    str = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "SHA1");
                    break;
                //如果Format的值为1，采用MD5的方式加密
                case 1:
                    str = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "MD5");
                    break;
            }
            return str;
        }

        //字符串取反
        public static string Reverse(string str)
        {
            int i;
            StringBuilder sb = new StringBuilder();
            for (i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
        public static Boolean isNum(string str)
        {
            Boolean isNumber = false;
            char[] myArray = new char[16];
            myArray = str.ToCharArray();
            for (int j = 0; j < myArray.Length; j++)
            {
                if(myArray[j]>='0'&&myArray[j]<='9'||myArray[j]==' ')
                {
                    isNumber = true;
                }
            }
            return isNumber;
        }

        public static string randString()
        {
            string str = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";//75个字符
            Random r = new Random();
            string result = string.Empty;

            //生成一个8位长的随机字符，具体长度可以自己更改
            for (int i = 0; i < 12; i++)
            {
                int m = r.Next(0, 62);//这里下界是0，随机数可以取到，上界应该是75，因为随机数取不到上界，也就是最大74，符合我们的题意
                string s = str.Substring(m, 1);
                result += s;
            }

            return result;
        }
    }