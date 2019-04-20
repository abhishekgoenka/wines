using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wines.WinForm.Models
{
    internal class ShopModel
    {
        public Int64 ID { get; set; }
        public string Shop_Name { get; set; }
        public string Address { get; set; }
        public bool License_Renewed { get; set; }
        public bool IMFL { get; set; }
        public bool CL { get; set; }
        public string Reserve1 { get; set; }

        public override string ToString()
        {
            return Shop_Name;
        }
    }
}
