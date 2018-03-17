using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TooLManagementEntities
{
    public class AddItemBo
    {
        public int UserId { get; set; }
        public bool IsAdmin { get; set; }


        public string ItemCateGory { get; set; }
        public string ItemGroup { get; set; }
        public string ItemType { get; set; }
        public string ItemCode { get; set; }
        public string ProductCode { get; set; }
        public string ItemDesc { get; set; }
        public string SereialNo { get; set; }
        public string Location { get; set; }
        public string ImagePath { get; set; }
        public string SupplierPartNo { get; set; }
        public string LastUnitCost { get; set; }
        public int   Quantity{ get; set; }
        public int MOQ { get; set; }
        public int ItemId { get; set; }
        public DateTime LastReceiptDate { get; set; }
        public int Accesslevel { get; set; }
    
        public string BarCode { get; set; }
      
       
        public string Supplier { get; set; }
        public string TypeOfmethod { get; set; }
    }

    public class AddSupplierBo
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Contranct { get; set; }
        public string Note { get; set; }
    }
}
