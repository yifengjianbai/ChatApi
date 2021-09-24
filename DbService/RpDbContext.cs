using DbService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbService
{
    public class RpDbContext: RedPaperContext
    {
        public static string ConnectStr = "";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ob = optionsBuilder;
            ob.UseSqlServer(ConnectStr);
            base.OnConfiguring(ob);
        }
    }
}
