﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Khanhlyluyentap1.Migrations
{
    [DbContext(typeof(LTQDD))]
    partial class LTQDDModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Khanhlyluyentap1.Models.Lop", b =>
                {
                    b.Property<string>("MaLop")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaSinhVien")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaLop");

                    b.ToTable("Lop");
                });

            modelBuilder.Entity("Khanhlyluyentap1.Models.SinhVien", b =>
                {
                    b.Property<string>("MaSinhVien")
                        .HasColumnType("TEXT");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSinhVien")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaSinhVien");

                    b.ToTable("SinhVien");
                });
#pragma warning restore 612, 618
        }
    }
}
