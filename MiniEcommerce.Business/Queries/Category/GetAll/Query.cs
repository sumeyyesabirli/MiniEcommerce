using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Business.Queries.Category.GetAll
{
    public class Query : IRequest<List<Dto>>
    {
    }
}
