// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Page.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20211018052145_Add")]
    partial class Add
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Page.Models.Add", b =>
                {
                    b.Property<string>("AddId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("AddName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AddId");

                    b.ToTable("Add");
                });
#pragma warning restore 612, 618
        }
    }
}
