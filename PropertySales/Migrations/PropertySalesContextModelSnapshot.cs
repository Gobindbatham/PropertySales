// <auto-generated />
using PropertySales.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PropertySales.Migrations
{
    [DbContext(typeof(PropertySalesContext))]
    partial class PropertySalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PropertySales.Models.BuyProperty", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfProperty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimentions")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<string>("PinCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("BuyProperty");
                });

            modelBuilder.Entity("PropertySales.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeOfProperty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimentions")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<string>("PinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("PropertySales.Models.ReachUs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ReachUs");
                });
#pragma warning restore 612, 618
        }
    }
}
