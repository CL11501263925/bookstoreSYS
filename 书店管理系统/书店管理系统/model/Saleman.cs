using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
  public  class Saleman
    {
        public int SalesmanID { get; set; }//销售员编号
        public string  SalesmanName { get; set; }//销售员名称
        public string  Mobile { get; set; }//手机号
        public string  Pwd { get; set; }//密码
        public string  Gender { get; set; }//性别
        public string  BaseSalary { get; set; }//工资
        public string  CommissionRate { get; set; }//提成
        public string Work { get; set; }//职务
    }
}
