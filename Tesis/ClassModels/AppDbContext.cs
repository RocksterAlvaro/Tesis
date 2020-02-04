using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

        public string AddOrDeleteStock(List<AppProducts> EditProductsList, string AddOrDeleteString)
        {
            // Parameters
            var NewStockProductsTable = DataTableExtensions.CreateDataTable2(EditProductsList);

            var ParameterNewStockProductsTable = new SqlParameter("@NewStockProductsTable", SqlDbType.Structured);
            ParameterNewStockProductsTable.Value = NewStockProductsTable;
            ParameterNewStockProductsTable.TypeName = "[dbo].[AspNetProductsType]"; // Products Table Type

            var ParameterAddOrDeleteString = new SqlParameter("@AddOrDelete", AddOrDeleteString);

            // Update stock in database
            var AddOrDeleteStockResponse = this.Database
                .ExecuteSqlCommand("EXEC [dbo].[SPAddOrDeleteStock] @NewStockProductsTable, @AddOrDelete",
                ParameterNewStockProductsTable,
                ParameterAddOrDeleteString);

            // If any product stock was updated
            if(AddOrDeleteStockResponse > 0)
            {
                // Get the new stock from the database
                var NewStock = this.AppProducts.FromSql("SPGetProducts @NewStockProductsTable", ParameterNewStockProductsTable).ToList();

                return JsonConvert.SerializeObject(NewStock);
            }

            return "";
        }
    }

    public static class DataTableExtensions
    {
        public static DataTable CreateDataTable1<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable CreateDataTable2<T>(IEnumerable<T> list)
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
