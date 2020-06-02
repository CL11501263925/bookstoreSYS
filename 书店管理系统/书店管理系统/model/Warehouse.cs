using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
  public  class Warehouse
    {
        public int WarehouseID { get; set; }//入库编号
        public int GoodID { get; set; }//书本编号
        public DateTime Time { get; set; }//入库时间
        public int InboundNum { get; set; }//入库数目
        public int SalesmenID { get; set; }//操作人
    }
}
