using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace e_StudyFile.Models
{
    public partial class DBEStudyFileContext : DbContext
    {
        public DBEStudyFileContext()
        {
        }

        public DBEStudyFileContext(DbContextOptions<DBEStudyFileContext> options)
          : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
