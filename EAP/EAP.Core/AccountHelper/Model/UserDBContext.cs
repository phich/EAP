using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EAP.Core.AccountHelper.Model
{
    class UserDBContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
       
        public UserDBContext(DbContextOptions options) : base(options)
        {
        }

        protected UserDBContext()
        {
        }
       
     
    }
}
