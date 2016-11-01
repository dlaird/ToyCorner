using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToyCorner.Models
{
    public class Item 
    {
        public Item ()
        {
            // put sets in this constructor ,remove them from the properties below
        }

        public int TypeID { get; set; }

        public string TypeName { get; set; }

        public string TypeDescription { get; set; }

        public int ItemID { get; set; }

        public string ItemName { get; set; }

        public string ItemDescription { get; set; }

        public float ItemPrice { get; set; }

        public IEnumerable<string> ItemImages { get; set;}
    }
}
