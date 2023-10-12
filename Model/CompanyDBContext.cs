using System.Data.Entity;

namespace QL_Thue_Xe_Dap.Model
{
    public class CompanyDBContext : DbContext
    {
        public CompanyDBContext() : base("ConnectionStrings") {}
        
        public DbSet<UserGroup> UserGroups { get; set; }

        public DbSet<User> Users { get; set; }
        
    }
}