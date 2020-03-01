﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Tesis.ClassModels
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        // Context constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // Nothing
        }

        // My tables
        public DbSet<AppProducts> AppProducts { get; set; }

        // Search in the DB for a certain product
        public string SearchBar(string SearchString)
        {
            if(SearchString != null)
            {
                // Parameters
                var ParameterSearchString = new SqlParameter("@SearchString", SearchString);

                var SearchProducts = this.AppProducts.FromSql("SPGetSearchProduct @SearchString", ParameterSearchString).ToList();

                return JsonConvert.SerializeObject(SearchProducts);
            }

            return ("");
        }

        public string InOrOutStock(List<AppProducts> EditProductsList, string InOrOutString, string StockOrSaleString)
        {
            // Parameters
            var NewStockProductsTable = DataTableExtensions.CreateDataTable(EditProductsList);

            var ParameterNewStockProductsTable = new SqlParameter("@NewStockProductsTable", SqlDbType.Structured);
            ParameterNewStockProductsTable.Value = NewStockProductsTable;
            ParameterNewStockProductsTable.TypeName = "[dbo].[AspNetProductsType]"; // Products Table Type

            var ParameterInOrOutString = new SqlParameter("@InOrOut", InOrOutString);
            var ParameterStockOrSaleString = new SqlParameter("@StockOrSale", StockOrSaleString);

            // Update stock in database
            var AddOrDeleteStockResponse = this.Database
                .ExecuteSqlCommand("EXEC [dbo].[SPInOrOutStock] @NewStockProductsTable, @InOrOut, @StockOrSale",
                ParameterNewStockProductsTable,
                ParameterInOrOutString,
                ParameterStockOrSaleString);

            // If any product stock was updated
            if(AddOrDeleteStockResponse > 0)
            {
                // Get the new stock from the database
                var NewStock = this.AppProducts.FromSql("SPGetProducts @NewStockProductsTable", ParameterNewStockProductsTable).ToList();

                return JsonConvert.SerializeObject(NewStock);
            }

            return "";
        }

        public string ZeroStock()
        {
            // Set all stock to zero
            var ZeroStockResponse = this.Database
                .ExecuteSqlCommand("EXEC [dbo].[SPZeroStock]");

            return "CHANGE";
        }
    }

    public static class DataTableExtensions
    {
        public static DataTable CreateDataTable<T>(IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}
