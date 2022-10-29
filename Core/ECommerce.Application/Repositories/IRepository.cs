using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Application.Repositories
{
    public interface IRepository<T> where T: BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
