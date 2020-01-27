using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
        public List<AppProducts> SearchBar(string SearchString)
        {
            if(SearchString != null)
            {
                // Parameters
                var ParameterSearchString = new SqlParameter("@SearchString", SearchString);

                var SearchProducts = this.AppProducts.FromSql("SPGetSearchProduct @SearchString", ParameterSearchString).ToList();

                return SearchProducts;
            }

            return new List<AppProducts>();
        }

    }
}
