using System.ComponentModel.DataAnnotations;

namespace BlazorSalesMS.Data
{
    public class DisInventory
    {
        public int Id { get; set; }
        public int? PId { get; set; }
        public string? DistributorName { get; set; }

        [Required(ErrorMessage = "Item name is required.")]
        [StringLength(100, ErrorMessage = "Item name cannot exceed 100 characters.")]
        public string ItemName { get; set; } = string.Empty;

        [Required(ErrorMessage = "SKU is required.")]
        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters.")]
        public string SKU { get; set; } = string.Empty;

        [Required(ErrorMessage = "sales system is required.")]
        [StringLength(50, ErrorMessage = "sales system cannot exceed 50 characters.")]
        public string SalesSystem { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Quantity on hand must be a non-negative number.")]
        public int QuantityOH { get; set; }

        [Required(ErrorMessage = "Unit is required.")]
        [StringLength(10, ErrorMessage = "Unit cannot exceed 10 characters.")]
        public string Unit { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required.")]
        [StringLength(20, ErrorMessage = "Category cannot exceed 20 characters.")]
        public string Category { get; set; } = string.Empty;

        [Range(0.01, 1000000, ErrorMessage = "Price must be greater than zero.")]
        public decimal? buingPrice { get; set; }

        [Range(0.01, 1000000, ErrorMessage = "Price must be greater than zero.")]
        public decimal ? SalesPrice { get; set; }
        public DateTime? RecepitDate { get; set; } 
        public DateTime?  LastUpdateQtyDate { get; set; }
        public DateTime?   ExpirationDate { get; set; }
    }
}
