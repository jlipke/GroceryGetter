using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryGetter.BL.Models
{
    public class Layout
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public string Title { get; set; }
        public List<Aisle> Aisles { get; set; }
    }
}
