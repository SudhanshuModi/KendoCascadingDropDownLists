using System.ComponentModel.DataAnnotations;

namespace KendoCascadingDropDownLists.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }
    }
    
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }

        public string BranchName { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }

}
