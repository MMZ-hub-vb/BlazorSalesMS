using System.ComponentModel.DataAnnotations;

namespace BlazorSalesMS.Data
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Item name is required.")]
        [StringLength(20, ErrorMessage = "Item name cannot exceed 100 characters.")]
        public string CategoryName { get; set; } = string.Empty;

        [Required(ErrorMessage = "SKU is required.")]
        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters.")]
        public string Description { get; set; } = string.Empty;
    }
}
