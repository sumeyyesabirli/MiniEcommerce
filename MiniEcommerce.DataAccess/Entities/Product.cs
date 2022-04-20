using MiniEcommerce.Core.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.DataAccess.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public float SalesPrice { get; set; }
        public float PurchasePrice { get; set; }
        public int CategoryId { get; set; }
    }
}
