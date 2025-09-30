using System.ComponentModel.DataAnnotations;

namespace BlazorSalesMS.Data
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Distbutor is required.")]
        [StringLength(100, ErrorMessage = "Distbutor cannot exceed 100 characters.")]
        public string DistributorName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Product Name is required.")]
        public string ProductName { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Quantity on hand must be a non-negative number.")]
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Order date is required.")]
        public DateTime OrderDate { get; set; } = DateTime.Now.Date;
        public int DistributorId { get; set; }
        public int ProductId { get; set; }
        public int QtyOh { get; set; }
        public string OrderCode { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
        public string Unit { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
