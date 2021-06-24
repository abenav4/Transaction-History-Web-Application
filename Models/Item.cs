using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purchase_Tracker_v2.Models
{
    public class Item
    {

        public int Id { get; set; }
        public string Purchase { get; set; }
        public int Cost { get; set; }
        public Item()
        {

        }
    }
}
