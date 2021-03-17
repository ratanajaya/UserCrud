using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserCrudAPI.BL
{
    public class InMemoryDbContext : IdentityDbContext
    {
        public InMemoryDbContext(DbContextOptions<InMemoryDbContext> options) : base(options) {

        }
    }
}
