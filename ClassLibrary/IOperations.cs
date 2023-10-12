using System;


namespace Oct6_Assignment
{
    internal interface IOperations
    {
        void AddToCart(int prodid, string pname, int qty, int price);
        void PaymentGateway(int amt);
        void BuyNow();
    }
}