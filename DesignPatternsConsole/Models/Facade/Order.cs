using System;

namespace DesignPatternsConsole.Models.Facade
{
    public class Order
    {
        private readonly Product _product = new Product();
        private readonly Payment _payment = new Payment();
        private readonly Invoice _invoice = new Invoice();

        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            _product.GetProductDetails();
            _payment.MakePayment();
            _invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}
