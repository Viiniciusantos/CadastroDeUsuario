using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App.TailorIT.Application.ViewModels;

    public class AppContext : DbContext
    {
        public AppContext (DbContextOptions<AppContext> options)
            : base(options)
        {
        }

        public DbSet<App.TailorIT.Application.ViewModels.UsuarioViewModel> UsuarioViewModel { get; set; }
    }
