using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Next.ECommerce.Application.Infrastructure.Repositories;
using Next.ECommerce.Application.Users.Models;
using Next.ECommerce.Domain.Entities;

namespace Next.ECommerce.Application.Users.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserModel>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<UserModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var entity = new User
            {
                UserId = request.UserId,
                UserName = request.UserName,
                Password = request.Password
            };

            _unitOfWork.Users.Add(entity);
            _unitOfWork.Complete();

            return UserModel.Create(entity);
        }
    }
}