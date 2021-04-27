using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapi_app_.MyModels;

namespace webapi_app_.Data
{
    public class webapi_app_Context : DbContext
    {
        public webapi_app_Context (DbContextOptions<webapi_app_Context> options)
            : base(options)
        {
        }

        public DbSet<webapi_app_.MyModels.Item> Item { get; set; }
    }
}
