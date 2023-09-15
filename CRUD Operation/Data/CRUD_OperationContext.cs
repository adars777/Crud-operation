using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_OPERATION.Models;

namespace CRUD_Operation.Data
{
    public class CRUD_OperationContext : DbContext
    {
        public CRUD_OperationContext (DbContextOptions<CRUD_OperationContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_OPERATION.Models.UserInfo> UserInfo { get; set; } = default!;
    }
}
