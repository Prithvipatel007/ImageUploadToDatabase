using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageToDatabase.Data
{
    public class ImageToDatabaseContext : DbContext
    {

        public ImageToDatabaseContext(DbContextOptions<ImageToDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Image> Image { get; set; }
    }
}
