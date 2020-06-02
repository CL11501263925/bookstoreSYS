using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
 public class Sales
    {
        public int SalesID { get; set; }//销售编号
        public string  ReceiptsCode { get; set; }//流水号
        public DateTime SalesDate { get; set; }//销售日期
        public string  Amount { get; set; }//数量
        public int SalesmanID { get; set; }//销售员名称
        public string  SalesName { get; set; }//销售人名字
    }
}
