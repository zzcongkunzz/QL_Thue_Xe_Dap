using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QL_Thue_Xe_Dap.Model
{
    [Table("Products")]
    public class User
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("UserGroupId")]
        public virtual UserGroup UserGroup { get; set; }
    }
}