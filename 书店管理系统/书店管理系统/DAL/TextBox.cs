using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
   public class TextBox
    {
        public static string pattern { get; set; }//正则表达式

       /// <summary>
       /// 验证文本框 0-字符串50 1-字符串20 2-正整数 3-电话号码 4-0~1小数
       /// </summary>
       /// <param name="text"></param>
       /// <param name="num"></param>
       /// <returns></returns>
       public static bool Intextnull(string text,int num)
       {
           bool error=true;//统计错误
           Match m;         
           switch (num)//根据传过来的值选择判断的正则
           {
               case 0://
                   TextBox.pattern = @"^[A-Za-z0-9]{1,50}$";//长度为50字符串
                   m = Regex.Match(text, pattern);
                   if (m.Success)
                       error = false;
                   break;
               case 1://
                  TextBox.pattern  = @"^[A-Za-z0-9]{1,20}|[\u4e00-\u9fa5]{1,20}$";//长度为20字符串
                    m = Regex.Match(text, pattern);   
                    if (m.Success)
                        error = false;
                   break;
               case 2:
                   TextBox.pattern = @"^[1-9]\d*|0$";//正整数
                   m = Regex.Match(text, pattern);   
                   if (m.Success)
                       error = false;
                   break;
               case 3:
                   TextBox.pattern = @"\d{3}\d{8}|\d{4}\{7,8}";//电话号码
                   m = Regex.Match(text, pattern);   
                   if (m.Success)
                       error = false;
                   break;
               case 4:
                   TextBox.pattern = @"^[1]|0\.\d*[1-9]\d*$";//0~1小数
                   m = Regex.Match(text, pattern);   
                   if (m.Success)
                       error = false;
                   break;          
                  //        
               case 5:
                   TextBox.pattern = @"^[^\x00*\xff]$";//验证姓名
                   m = Regex.Match(text, pattern);
                   if (m.Success)
                       error = false;
                   break;      
           }          
           return error;
       }
    }
}
