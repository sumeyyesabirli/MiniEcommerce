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
    public class ProductRepository : BaseRepository<Product, EfDbContext>, IProductRepository
    {
        public ProductRepository(EfDbContext context) : base(context)
        {

        }
    }
}
