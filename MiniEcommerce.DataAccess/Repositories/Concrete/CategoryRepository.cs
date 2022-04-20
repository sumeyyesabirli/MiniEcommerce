using MiniEcommerce.Core.Repositories.Concrete;
using MiniEcommerce.DataAccess.Context;
using MiniEcommerce.DataAccess.Entities;
using MiniEcommerce.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.DataAccess.Repositories.Concrete
{
    public class CategoryRepository : BaseRepository<Category,EfDbContext>, ICategoryRepository
    {
        public CategoryRepository(EfDbContext context) :  base(context)
        {

        }
    }
}
