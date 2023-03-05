using System.ComponentModel.DataAnnotations;

namespace OrderReceivingApp.Models
{
    public class Order
    {
        public int? OrderNo { get; set; }

        [Required(ErrorMessage = "'{0}' must be supplied.")]
        public DateTime? OrderDate { get; set; }

        [Required(ErrorMessage = "'{0}' must be supplied.")]
        [Range(0, Double.MaxValue, ErrorMessage = "'{0}' must be a positive number.")]
        public double InvoicePrice { get; set; }

        [Required(ErrorMessage = "'{0}' must be supplied.")]
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
