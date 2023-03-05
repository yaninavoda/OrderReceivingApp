using System.ComponentModel.DataAnnotations;

namespace OrderReceivingApp.Models
{
    public class Product
    {
        [Required(ErrorMessage = "'{0}' must be supplied.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "'{0}' must be a positive number.")]
        public int ProductCode { get; set; }

        [Required(ErrorMessage = "'{0}' must be supplied.")]
        [Range(1, Double.MaxValue, ErrorMessage = "'{0}' must be a positive number.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "'{0}' must be supplied.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "'{0}' must be a positive number.")]
        public int Quantity { get; set; }
    }
}