using System.ComponentModel.DataAnnotations;

namespace BlazorSalesMS.Data
{
    public class Recepit
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Item name is required.")]
        [StringLength(100, ErrorMessage = "Item name cannot exceed 100 characters.")]
        public string ItemName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Suplyer is required.")]
        [StringLength(50, ErrorMessage = "Suplyer cannot exceed 50 characters.")]
        public string Supplyer { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(150, ErrorMessage = "Address cannot exceed 150 characters.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\+?[0-9]\d{7,12}$",
        ErrorMessage = "Enter a valid phone number (e.g., 0123456789132).")]
        public string ContactNo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Invoice no is required.")]
        [StringLength(14, ErrorMessage = "Invoice no cannot exceed 14 characters.")]
        public string IvoiceNo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Method is required.")]
        [StringLength(14, ErrorMessage = "Method cannot exceed 14 characters.")]
        public string PaymentMethod { get; set; } = string.Empty;

     
        public string UrlDocName { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a non-negative number.")]
        public int Quantity { get; set; }

        [Range(0.01, 1000000, ErrorMessage = "Price must be greater than zero.")]
        public decimal UnitPrice { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Recepit date is required.")]
        public DateTime RecepitDate { get; set; } = DateTime.Now.Date;

       
    }
}
