using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MiniEcommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediatr;
        public CategoryController(IMediator mediator)
        {
            _mediatr = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] Business.Queries.Category.GetAll.Query query)
        {
            var response = await _mediatr.Send(query);
            return Ok(response);
        }
    }
}
