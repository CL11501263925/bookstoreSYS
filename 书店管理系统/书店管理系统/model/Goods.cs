using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Books
    {
        public int BooksID { get; set; }//书本编号
        public string BooksName { get; set; }//书本名称
        public int TypeID { get; set; }//类型编号
        public string BarCode { get; set; }//条形码
        public decimal StorePrice { get; set; }//进价
        public decimal SalePrice { get; set; }//售价
        public decimal Discount { get; set; }//折扣       
        public int StockNum { get; set; }//库存
        public DateTime StockDate { get; set; }//入库日期
    }
}
