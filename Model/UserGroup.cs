using System.ComponentModel.DataAnnotations;

namespace QL_Thue_Xe_Dap.Model
{
    public class UserGroup
    {
        [Key] 
        public long Id { get; set; }

        public string Name { get; set; }
    }
}