namespace OOP02
{
    // ==========================================
    // Standard Shipment
    // ==========================================
    public class StandardShipment : Shipment
    {
        public StandardShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                new DeliveryAddress())
        {
        }


        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();

            base.PrintShipment();
        }
    }
}