// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesBudget.DataAccess.Data;

namespace SalesBudget.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211013071359_newdb")]
    partial class newdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesBudget.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acronym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrenyGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Operative")
                        .HasColumnType("bit");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("SalesBudget.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerGroupCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicensingArea")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("SalesBudget.Models.ExchangeRate", b =>
                {
                    b.Property<int>("ExchangeRateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrencyAcronym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ExRate")
                        .HasColumnType("float");

                    b.Property<double>("InterCompanyRate")
                        .HasColumnType("float");

                    b.Property<string>("Scenario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ExchangeRateId");

                    b.ToTable("ExchangeRate");
                });

            modelBuilder.Entity("SalesBudget.Models.FBudget", b =>
                {
                    b.Property<int>("BudgetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ExchangeRateId")
                        .HasColumnType("int");

                    b.Property<string>("FreeOfCharge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemMasterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LedgerTypeId")
                        .HasColumnType("int");

                    b.Property<string>("MonthNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.Property<float>("QuantityKg")
                        .HasColumnType("real");

                    b.Property<float>("TotalImport")
                        .HasColumnType("real");

                    b.Property<string>("UnitOfMeasure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("BudgetId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ExchangeRateId");

                    b.HasIndex("ItemMasterId");

                    b.HasIndex("LedgerTypeId");

                    b.ToTable("Budget");
                });

            modelBuilder.Entity("SalesBudget.Models.ItemMaster", b =>
                {
                    b.Property<int>("ItemMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemNumber")
                        .HasColumnType("int");

                    b.Property<int>("PharmaFormId")
                        .HasColumnType("int");

                    b.Property<int>("ProductGroupId")
                        .HasColumnType("int");

                    b.Property<string>("ShortItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnToBulkId")
                        .HasColumnType("int");

                    b.Property<int>("UnToKgId")
                        .HasColumnType("int");

                    b.Property<string>("UnitOfMeasure")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemMasterId");

                    b.HasIndex("PharmaFormId");

                    b.HasIndex("ProductGroupId");

                    b.HasIndex("UnToBulkId");

                    b.HasIndex("UnToKgId");

                    b.ToTable("ItemMaster");
                });

            modelBuilder.Entity("SalesBudget.Models.LedgerType", b =>
                {
                    b.Property<int>("LedgerTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LedgerTypeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scenario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Statutory")
                        .HasColumnType("bit");

                    b.HasKey("LedgerTypeId");

                    b.ToTable("LedgerType");
                });

            modelBuilder.Entity("SalesBudget.Models.PharmaForm", b =>
                {
                    b.Property<int>("PharmaFormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PharmaFormAcronym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PharmaFormName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PharmaFormId");

                    b.ToTable("PharmaForm");
                });

            modelBuilder.Entity("SalesBudget.Models.ProductGroup", b =>
                {
                    b.Property<int>("ProductGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductGroupAcronym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductGroupCode")
                        .HasColumnType("int");

                    b.Property<string>("ProductGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductGroupId");

                    b.ToTable("ProductGroup");
                });

            modelBuilder.Entity("SalesBudget.Models.UnToBulk", b =>
                {
                    b.Property<int>("UnToBulkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConversionRate")
                        .HasColumnType("int");

                    b.HasKey("UnToBulkId");

                    b.ToTable("UnToBulk");
                });

            modelBuilder.Entity("SalesBudget.Models.UnToKg", b =>
                {
                    b.Property<int>("UnToKgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ConversionRate")
                        .HasColumnType("float");

                    b.HasKey("UnToKgId");

                    b.ToTable("UnToKg");
                });

            modelBuilder.Entity("SalesBudget.Models.FBudget", b =>
                {
                    b.HasOne("SalesBudget.Models.Company", "Company")
                        .WithMany("FBudgets")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesBudget.Models.Customer", "Customer")
                        .WithMany("FBudgets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesBudget.Models.ExchangeRate", "ExchangeRate")
                        .WithMany("FBudgets")
                        .HasForeignKey("ExchangeRateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesBudget.Models.ItemMaster", "ItemMaster")
                        .WithMany("FBudgets")
                        .HasForeignKey("ItemMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesBudget.Models.LedgerType", "LedgerType")
                        .WithMany("FBudgets")
                        .HasForeignKey("LedgerTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Customer");

                    b.Navigation("ExchangeRate");

                    b.Navigation("ItemMaster");

                    b.Navigation("LedgerType");
                });

            modelBuilder.Entity("SalesBudget.Models.ItemMaster", b =>
                {
                    b.HasOne("SalesBudget.Models.PharmaForm", "PharmaForm")
                        .WithMany("ItemMasters")
                        .HasForeignKey("PharmaFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesBudget.Models.ProductGroup", "ProductGroup")
                        .WithMany("ItemMasters")
                        .HasForeignKey("ProductGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesBudget.Models.UnToBulk", "UnToBulk")
                        .WithMany("ItemMasters")
                        .HasForeignKey("UnToBulkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesBudget.Models.UnToKg", "UnToKg")
                        .WithMany("ItemMasters")
                        .HasForeignKey("UnToKgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PharmaForm");

                    b.Navigation("ProductGroup");

                    b.Navigation("UnToBulk");

                    b.Navigation("UnToKg");
                });

            modelBuilder.Entity("SalesBudget.Models.Company", b =>
                {
                    b.Navigation("FBudgets");
                });

            modelBuilder.Entity("SalesBudget.Models.Customer", b =>
                {
                    b.Navigation("FBudgets");
                });

            modelBuilder.Entity("SalesBudget.Models.ExchangeRate", b =>
                {
                    b.Navigation("FBudgets");
                });

            modelBuilder.Entity("SalesBudget.Models.ItemMaster", b =>
                {
                    b.Navigation("FBudgets");
                });

            modelBuilder.Entity("SalesBudget.Models.LedgerType", b =>
                {
                    b.Navigation("FBudgets");
                });

            modelBuilder.Entity("SalesBudget.Models.PharmaForm", b =>
                {
                    b.Navigation("ItemMasters");
                });

            modelBuilder.Entity("SalesBudget.Models.ProductGroup", b =>
                {
                    b.Navigation("ItemMasters");
                });

            modelBuilder.Entity("SalesBudget.Models.UnToBulk", b =>
                {
                    b.Navigation("ItemMasters");
                });

            modelBuilder.Entity("SalesBudget.Models.UnToKg", b =>
                {
                    b.Navigation("ItemMasters");
                });
#pragma warning restore 612, 618
        }
    }
}
