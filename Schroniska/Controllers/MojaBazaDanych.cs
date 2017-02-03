using Schroniska.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Schroniska.Controllers
{
    public class MojaBazaDanych : DbContext
    {
        public MojaBazaDanych() : base("BazaConnection")
        {

        }
        public DbSet<Schronisko> Schroniska { get; set; }
        public DbSet<Recenzja> Recenzje { get; set; }
    }
}