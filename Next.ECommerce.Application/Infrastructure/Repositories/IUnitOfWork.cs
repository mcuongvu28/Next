using System;
using System.Collections.Generic;
using System.Text;

namespace Next.ECommerce.Application.Infrastructure.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        int Complete();
    }
}
