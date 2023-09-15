using System.ComponentModel.DataAnnotations;

namespace CRUD_OPERATION.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string? firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string? lastName { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }


        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string MobileNo { get; set; }


        [Required]
        [Display(Name = "City")]
        public string? City { get; set; }
    }
}
