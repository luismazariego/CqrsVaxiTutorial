namespace ShopServices.Author.Api.Controllers
{
    using System.Threading.Tasks;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using ShopServices.Author.Api.Application;

    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //TODO: Refactor this
        [HttpPost]
        public async Task<ActionResult<Unit>> Create(NewAuthor.Execute data)
        {
            return await _mediator.Send(data);
        }
    }
}