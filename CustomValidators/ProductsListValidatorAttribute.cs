using OrderReceivingApp.Models;
using System.ComponentModel.DataAnnotations;

namespace OrderReceivingApp.CustomValidators
{
    public class ProductsListValidatorAttribute : ValidationAttribute
    {
        public string DefaultErrorMessage { get; set; } = "Order should have at least one product";

        public ProductsListValidatorAttribute()
        {
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //check if the value of "Products" property is not null
            if (value != null)
            {
                var products = (List<Product>)value;
                // check if Products has at least one member
                if (products.Count > 0) 
                {
                    //no validation error
                    return ValidationResult.Success;
                }
                //return validation error
                else return new ValidationResult(DefaultErrorMessage, new string[] { nameof(validationContext.MemberName) });
            }
            return null;
        }
    }
}