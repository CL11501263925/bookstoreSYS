using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public class TextBoxBll
    {
        /// <summary>
       /// 验证文本框 1-字符串20 2-正整数 3-电话号码 4-小数
       /// </summary>
       /// <param name="text"></param>
       /// <param name="num"></param>
       /// <returns></returns>
       public static bool Intextnull(string text, int num)
       {
           return DAL.TextBox.Intextnull(text,num);
       }
    }
}
