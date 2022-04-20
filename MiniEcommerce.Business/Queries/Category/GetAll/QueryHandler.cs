using MediatR;
using MiniEcommerce.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniEcommerce.Business.Queries.Category.GetAll
{
    public class QueryHandler : IRequestHandler<Query, List<Dto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        public QueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<Dto>> Handle(Query request, CancellationToken cancellationToken)
        {
            var response = await _categoryRepository.GetAll();
            return response.Select(x => new Dto
            {
                Id = x.Id,
                Name = x.Name,
                IsActive = x.IsActive,
                //ChildCategories = new List<Dto> { }
            }).ToList();
        }
    }
}
