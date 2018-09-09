

using System;
using System.Linq.Expressions;
using Next.ECommerce.Domain.Entities;

namespace Next.ECommerce.Application.Users.Models
{
    public class UserModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public static Expression<Func<User, UserModel>> Projection
        {
            get
            {
                return user => new UserModel
                {
                    UserId = user.UserId,
                    UserName = user.UserName,
                    Password = user.Password
                };
            }
        }

        public static UserModel Create(User user) => 
            Projection.Compile().Invoke(user);
    }
}
