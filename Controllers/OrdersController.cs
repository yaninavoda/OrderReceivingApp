using Microsoft.AspNetCore.Mvc;
using OrderReceivingApp.Models;

namespace OrderReceivingApp.Controllers
{
    public class OrdersController : Controller
    {
        [Route("order")]
        public IActionResult Index(Order order)
        {
            var random = new Random();
            order.OrderNo = random.Next(1, 1000000);
            order.InvoicePrice = TotalInvoicePrice(order.Products);
            
            if (ModelState.IsValid)
            {
                return Json(order);
            }
            else
            {
                var errors = string.Join("\n",
                    ModelState.Values.SelectMany(values => values.Errors)
                    .Select(error => error.ErrorMessage).ToList());

                return BadRequest(errors);
            }
        }

        private double TotalInvoicePrice(List<Product> products)
        {
            double invoiceTotal = 0;
            foreach (var product in products)
            {
                double totalForProduct = product.Quantity * product.Price;
                invoiceTotal += totalForProduct;
            }

            return invoiceTotal;
        }
    }
}
