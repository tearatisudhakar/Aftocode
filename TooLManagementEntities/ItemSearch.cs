using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TooLManagementEntities
{
    public class ItemSearch
    {
        public bool AdvancedSearch { get; set; }
        public string ItemCode { get; set; }
        public string ItemGroup { get; set; }
        public string ItemSubGroup { get; set; }
        public string ItemSupplier { get; set; }
        public int ItemQuanity { get; set; }
        public string QuantityType { get; set; }

    }
}
