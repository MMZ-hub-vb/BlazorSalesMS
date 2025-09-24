using System.ComponentModel.DataAnnotations;

namespace BlazorSalesMS.Data
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Item name is required.")]
        [StringLength(100, ErrorMessage = "Item name cannot exceed 100 characters.")]
        public string ItemName { get; set; } = string.Empty;

        [Required(ErrorMessage = "SKU is required.")]
        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters.")]
        public string SKU { get; set; } = string.Empty;

        [Required(ErrorMessage = "Unit is required.")]
        [StringLength(10, ErrorMessage = "Unit cannot exceed 10 characters.")]
        public string Unit { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required.")]
        [StringLength(20, ErrorMessage = "Category cannot exceed 20 characters.")]
        public string Category { get; set; } = string.Empty;

        [Range(0.01, 1000000, ErrorMessage = "Price must be greater than zero.")]
        public decimal PdnPrice { get; set; }

        [Range(0.01, 1000000, ErrorMessage = "Price must be greater than zero.")]
        public decimal SalesPrice { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Last Update date is required.")]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now.Date;

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Expiration date is required.")]
        public DateTime ExpirationDate { get; set; } = DateTime.Now.Date;
    }
}
