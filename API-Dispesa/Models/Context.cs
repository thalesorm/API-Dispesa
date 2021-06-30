﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Dispesa.Models
{
    public class Context : DbContext
    {
        public DbSet<Dispesa> Dispesas { get; set; }
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
