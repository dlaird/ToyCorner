using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyCorner.Interfaces
{
    interface IItem
    {
        string TypeName { get; set; }

        string ItemName { get; set; }
    }
}
