using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Next.ECommerce.Manager.Controllers
{
    public abstract class BaseController : Controller
    {
        private IMediator _mediator;

        protected IMediator Mediator =>
            _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());
    }
}