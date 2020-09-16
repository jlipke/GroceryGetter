using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryGetter.BL.Models
{
    public class Aisle
    {
        public Guid Id { get; set; }
        public Guid LayoutId { get; set; }
        public string Number { get; set; }
        public List<Product> Products { get; set; }
        public int Lineup { get; set; }
    }
}
