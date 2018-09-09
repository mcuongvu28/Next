using MediatR;
using Next.ECommerce.Application.Users.Models;

namespace Next.ECommerce.Application.Users.Commands
{
    public class CreateUserCommand : IRequest<UserModel>
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}