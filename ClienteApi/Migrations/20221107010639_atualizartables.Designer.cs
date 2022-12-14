// <auto-generated />
using ClienteApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClienteApi.Migrations
{
    [DbContext(typeof(UsuarioDbContext))]
    [Migration("20221107010639_atualizartables")]
    partial class atualizartables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ClienteApi.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("rua");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("senha");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("uf");

                    b.HasKey("Id");

                    b.ToTable("usuarios", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
