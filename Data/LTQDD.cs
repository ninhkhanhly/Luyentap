using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Khanhlyluyentap1.Models;

    public class LTQDD : DbContext
    {
        public LTQDD (DbContextOptions<LTQDD> options)
            : base(options)
        {
        }

        public DbSet<Khanhlyluyentap1.Models.SinhVien> SinhVien { get; set; } = default!;

public DbSet<Khanhlyluyentap1.Models.Lop> Lop { get; set; } = default!;
    }
