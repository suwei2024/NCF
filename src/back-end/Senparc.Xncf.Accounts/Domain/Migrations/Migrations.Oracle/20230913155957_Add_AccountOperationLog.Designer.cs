﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using Senparc.Xncf.Accounts.Models;

#nullable disable

namespace Senparc.Xncf.Accounts.Domain.Migrations.Migrations.Oracle
{
    [DbContext(typeof(AccountSenparcEntities_Oracle))]
    [Migration("20230913155957_Add_AccountOperationLog")]
    partial class Add_AccountOperationLog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Senparc.Xncf.Accounts.Domain.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("AdminRemark")
                        .HasMaxLength(300)
                        .HasColumnType("NVARCHAR2(300)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR2(30)");

                    b.Property<string>("Country")
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR2(30)");

                    b.Property<string>("District")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool?>("EmailChecked")
                        .HasColumnType("NUMBER(1)");

                    b.Property<bool>("Flag")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("HeadImgUrl")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("LastLoginIP")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("LastWeixinSignInTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<decimal>("LockMoney")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<bool?>("Locked")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("Note")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("Package")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("PasswordSalt")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR2(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.Property<bool?>("PhoneChecked")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("PicUrl")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR2(300)");

                    b.Property<decimal>("Points")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("Province")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.Property<string>("QQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("RealName")
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Remark")
                        .HasMaxLength(300)
                        .HasColumnType("NVARCHAR2(300)");

                    b.Property<byte>("Sex")
                        .HasColumnType("NUMBER(3)");

                    b.Property<int>("TenantId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ThisLoginIp")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR2(30)")
                        .HasColumnName("ThisLoginIP");

                    b.Property<DateTime>("ThisLoginTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("WeixinOpenId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("WeixinSignTimes")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("WeixinUnionId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Senparc.Xncf.Accounts.Domain.Models.AccountOperationLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("AdminRemark")
                        .HasMaxLength(300)
                        .HasColumnType("NVARCHAR2(300)");

                    b.Property<bool>("Flag")
                        .HasColumnType("NUMBER(1)");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Note")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("OperateTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Operator")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Remark")
                        .HasMaxLength(300)
                        .HasColumnType("NVARCHAR2(300)");

                    b.Property<int>("TenantId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("AccountOperationLogs");
                });

            modelBuilder.Entity("Senparc.Xncf.Accounts.Domain.Models.AccountPayLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("AddIp")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("AdminRemark")
                        .HasMaxLength(300)
                        .HasColumnType("NVARCHAR2(300)");

                    b.Property<DateTime>("CompleteTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Flag")
                        .HasColumnType("NUMBER(1)");

                    b.Property<decimal>("GetPoints")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("OrderType")
                        .HasColumnType("NUMBER(10)");

                    b.Property<decimal>("PayMoney")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("PayParam")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("PayType")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("PrepayId")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("Remark")
                        .HasMaxLength(300)
                        .HasColumnType("NVARCHAR2(300)");

                    b.Property<byte>("Status")
                        .HasColumnType("NUMBER(3)");

                    b.Property<int>("TenantId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("TradeNumber")
                        .HasColumnType("varchar(150)");

                    b.Property<byte?>("Type")
                        .HasColumnType("NUMBER(3)");

                    b.Property<decimal?>("UsedPoints")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountPayLogs");
                });

            modelBuilder.Entity("Senparc.Xncf.Accounts.Domain.Models.PointsLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("AccountPayLogId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("AdminRemark")
                        .HasMaxLength(300)
                        .HasColumnType("NVARCHAR2(300)");

                    b.Property<decimal>("AfterPoints")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BeforePoints")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("Flag")
                        .HasColumnType("NUMBER(1)");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<decimal>("Points")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Remark")
                        .HasMaxLength(300)
                        .HasColumnType("NVARCHAR2(300)");

                    b.Property<int>("TenantId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("AccountPayLogId");

                    b.ToTable("PointsLogs");
                });

            modelBuilder.Entity("Senparc.Xncf.Accounts.Domain.Models.AccountPayLog", b =>
                {
                    b.HasOne("Senparc.Xncf.Accounts.Domain.Models.Account", "Account")
                        .WithMany("AccountPayLogs")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Senparc.Xncf.Accounts.Domain.Models.PointsLog", b =>
                {
                    b.HasOne("Senparc.Xncf.Accounts.Domain.Models.Account", "Account")
                        .WithMany("PointsLogs")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Senparc.Xncf.Accounts.Domain.Models.AccountPayLog", "AccountPayLog")
                        .WithMany("PointsLogs")
                        .HasForeignKey("AccountPayLogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Account");

                    b.Navigation("AccountPayLog");
                });

            modelBuilder.Entity("Senparc.Xncf.Accounts.Domain.Models.Account", b =>
                {
                    b.Navigation("AccountPayLogs");

                    b.Navigation("PointsLogs");
                });

            modelBuilder.Entity("Senparc.Xncf.Accounts.Domain.Models.AccountPayLog", b =>
                {
                    b.Navigation("PointsLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
