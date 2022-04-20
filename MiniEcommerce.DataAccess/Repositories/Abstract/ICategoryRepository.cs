using MiniEcommerce.Core.Repositories.Abstract;
using MiniEcommerce.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.DataAccess.Repositories.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
