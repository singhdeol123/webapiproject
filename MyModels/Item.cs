using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi_app_.MyModels
{
    public class Item
    {
        //item id
        public int Id { get; set; }

        //The name of the company
        public string Company { get; set; }

        //Price of  one item item
        public decimal Price { get; set; }

        //The total number of items in the company.
        public int NumberOfitems { get; set; }
    }
}
