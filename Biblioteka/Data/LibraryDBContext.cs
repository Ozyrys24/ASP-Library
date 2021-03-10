using Biblioteka.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka.Data
{
    public class LibraryDBContext : DbContext
    {
        private readonly DbContextOptions _options;
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options) : base(options)
        {
            options = options;
        }

        public DbSet<BooksModel> BooksModel { get; set; }
    }
}
