using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
  public   class Vip
    {
        public int VipID { get; set; }//会员编号
        public string  VipName { get; set; }//会员名称
        public string  Mobile { get; set; }//电话号码
        public string  Gender { get; set; }//性别

        public int jifen { get; set; }//积分
    }
}
