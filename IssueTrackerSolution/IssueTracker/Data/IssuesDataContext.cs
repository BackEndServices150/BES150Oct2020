using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Data
{
    public class IssuesDataContext : DbContext
    {

        public IssuesDataContext(DbContextOptions<IssuesDataContext> options) : base(options)
        {
            
        }
        public DbSet<Defect> Defects { get; set; }
    }
}
