public abstract class DeliveryPlatform

{
    public string PartnerName { get; set; }

    //Non abstract Method
    public void TrackOrder()
    {
        Console.WriteLine("Order is being tracked : " + PartnerName);
    }
   //Abstracted in nature where implementation is defined by partner
    public abstract void DeliveryOrder();

}


public interface IpaymentGateway
{
   
    //by default methods are abstract 
    void ProcessPayment();
    
}

class ZomatoPartner : DeliveryPlatform, IpaymentGateway
{

    public override void DeliveryOrder()
    {

        Console.WriteLine("Delivered in 20 mins ");
    }

    public  void ProcessPayment()
    {
        Console.WriteLine("Payment Gateway ( Paytm ) transaction Started ... ");
    }


}


class DeliveryApp
{


    static void Main()
    {
        DeliveryPlatform partner = new ZomatoPartner(); // creating an object of implementation class
        partner.PartnerName = "Zomato";

        partner.TrackOrder();
        partner.DeliveryOrder();

        IpaymentGateway payment = (IpaymentGateway)partner;
        payment.ProcessPayment();

    }
}



