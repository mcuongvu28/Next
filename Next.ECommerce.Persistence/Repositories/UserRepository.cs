using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Next.ECommerce.Application.Infrastructure.Repositories;
using Next.ECommerce.Domain.Entities;

namespace Next.ECommerce.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

        public ECommerceDbContext PlutoContext
        {
            get => Context as ECommerceDbContext; 
        }
    }
}