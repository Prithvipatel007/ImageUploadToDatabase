using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ImageToDb.Models
{
    public class ImageToDbContext : DbContext
    {
        public ImageToDbContext (DbContextOptions<ImageToDbContext> options)
            : base(options)
        {
        }

        public DbSet<ImageToDb.Models.Image> Image { get; set; }
    }
}
