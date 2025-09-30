using System.ComponentModel.DataAnnotations;

namespace BlazorSalesMS.Data
{
    public class Distributor
    {
        public int Id { get; set; }
        public string Code { get; set; }=string.Empty;
        public string DocUrl1 { get; set; } = string.Empty;
        public string DocUrl12 { get; set; } = string.Empty;
        public string Zone { get; set; } = string.Empty;

        [Required(ErrorMessage = "company name is required.")]
        [StringLength(100, ErrorMessage = "Company name cannot exceed 100 characters.")]
        public string CompanyName { get; set; } = string.Empty;
       
        [Required(ErrorMessage = "name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string PersonName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(250, ErrorMessage = "Address cannot exceed 250 characters.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\+?[0-9]\d{7,12}$",
       ErrorMessage = "Enter a valid phone number (e.g., 0123456789132).")]
        public string Contact { get; set; } = string.Empty;
    }
}
