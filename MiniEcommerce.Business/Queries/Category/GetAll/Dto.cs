using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Business.Queries.Category.GetAll
{
    public class Dto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public List<Dto> ChildCategories { get; set; }
    }
}
