using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evira.Data.DbContext
{
    public class EviraDbContext
    {
        public EviraDbContext(DbContextOptions<EviraDbContext> options): base(options)
        {    
        }
    }
}
