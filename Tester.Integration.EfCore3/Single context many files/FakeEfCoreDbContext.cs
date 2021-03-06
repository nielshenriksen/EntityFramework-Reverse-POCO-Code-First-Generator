// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.co.uk/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Registered to: Simon Hughes
// Company      : Reverse POCO
// Licence Type : Commercial
// Licences     : 1
// Valid until  : 03 NOV 2020
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Connection String Name: "EfCoreDatabase"
//     Connection String:      "Data Source=(local);Initial Catalog=EfrpgTest;Integrated Security=True"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Developer Edition (64-bit)
// Database Engine Edition: Enterprise
// Database Version       : 14.0.2027.2

// <auto-generated>
// ReSharper disable CheckNamespace
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedVariable
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantCast
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// ReSharper disable UsePatternMatching
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3.Single_context_many_files
{
    public class FakeEfCoreDbContext : IEfCoreDbContext
    {
        public DbSet<ColumnName> ColumnNames { get; set; } // ColumnNames
        public DbSet<Stafford_Boo> Stafford_Boos { get; set; } // Boo
        public DbSet<Stafford_ComputedColumn> Stafford_ComputedColumns { get; set; } // ComputedColumns
        public DbSet<Stafford_Foo> Stafford_Foos { get; set; } // Foo
        public DbSet<Synonyms_Child> Synonyms_Children { get; set; } // Child
        public DbSet<Synonyms_Parent> Synonyms_Parents { get; set; } // Parent
        public DbSet<UserInfo> UserInfoes { get; set; } // UserInfo
        public DbSet<UserInfoAttribute> UserInfoAttributes { get; set; } // UserInfoAttributes

        public FakeEfCoreDbContext()
        {
            _database = null;

            ColumnNames = new FakeDbSet<ColumnName>("C36");
            Stafford_Boos = new FakeDbSet<Stafford_Boo>("Id");
            Stafford_ComputedColumns = new FakeDbSet<Stafford_ComputedColumn>("Id");
            Stafford_Foos = new FakeDbSet<Stafford_Foo>("Id");
            Synonyms_Children = new FakeDbSet<Synonyms_Child>("ChildId");
            Synonyms_Parents = new FakeDbSet<Synonyms_Parent>("ParentId");
            UserInfoes = new FakeDbSet<UserInfo>("Id");
            UserInfoAttributes = new FakeDbSet<UserInfoAttribute>("Id");

        }

        public int SaveChangesCount { get; private set; }
        public virtual int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public virtual int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            return SaveChanges();
        }

        public virtual Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }
        public virtual Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return Task<int>.Factory.StartNew(x => 1, acceptAllChangesOnSuccess, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private DatabaseFacade _database;
        public DatabaseFacade Database { get { return _database; } }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        // Stored Procedures

        public DbSet<Synonyms_SimpleStoredProcReturnModel> Synonyms_SimpleStoredProcReturnModel { get; set; }
        public List<Synonyms_SimpleStoredProcReturnModel> Synonyms_SimpleStoredProc(int? inputInt)
        {
            int procResult;
            return Synonyms_SimpleStoredProc(inputInt, out procResult);
        }

        public List<Synonyms_SimpleStoredProcReturnModel> Synonyms_SimpleStoredProc(int? inputInt, out int procResult)
        {
            procResult = 0;
            return new List<Synonyms_SimpleStoredProcReturnModel>();
        }

        public Task<List<Synonyms_SimpleStoredProcReturnModel>> Synonyms_SimpleStoredProcAsync(int? inputInt)
        {
            int procResult;
            return Task.FromResult(Synonyms_SimpleStoredProc(inputInt, out procResult));
        }

        // Table Valued Functions

        // dbo.CsvToInt
        public IQueryable<CsvToIntReturnModel> CsvToInt(string array, string array2)
        {
            return new List<CsvToIntReturnModel>().AsQueryable();
        }

        // Scalar Valued Functions

        // dbo.udfNetSale
        public decimal UdfNetSale(int? quantity, decimal? listPrice, decimal? discount)
        {
            return default(decimal);
        }
    }
}
// </auto-generated>

