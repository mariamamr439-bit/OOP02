using System;

namespace OOP02
{

    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();

            DeliveryCenter center = new DeliveryCenter(centerName);


            Console.WriteLine();
            Console.WriteLine("Enter Standard Shipment Data");

            Console.Write("Tracking Code: ");
            string standardTrackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string standardDescription = Console.ReadLine();

            Console.Write("Weight: ");
            decimal standardWeight =
                decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal standardDeliveryFee =
                decimal.Parse(Console.ReadLine());


            StandardShipment standardShipment =
                new StandardShipment(
                    standardTrackingCode,
                    standardDescription,
                    standardWeight,
                    standardDeliveryFee
                );


            if (center.AddShipment(standardShipment))
                Console.WriteLine("Shipment Added Successfully.");



            Console.WriteLine();
            Console.WriteLine("Enter Express Shipment Data");

            Console.Write("Tracking Code: ");
            string expressTrackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string expressDescription = Console.ReadLine();

            Console.Write("Weight: ");
            decimal expressWeight =
                decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal expressDeliveryFee =
                decimal.Parse(Console.ReadLine());

            Console.Write("Extra Fee: ");
            decimal extraFee =
                decimal.Parse(Console.ReadLine());


            ExpressShipment expressShipment =
                new ExpressShipment(
                    expressTrackingCode,
                    expressDescription,
                    expressWeight,
                    expressDeliveryFee,
                    extraFee
                );


            if (center.AddShipment(expressShipment))
                Console.WriteLine("Shipment Added Successfully.");


            Console.WriteLine();
            Console.WriteLine("Enter International Shipment Data");

            Console.Write("Tracking Code: ");
            string internationalTrackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string internationalDescription = Console.ReadLine();

            Console.Write("Weight: ");
            decimal internationalWeight =
                decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal internationalDeliveryFee =
                decimal.Parse(Console.ReadLine());

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();

            Console.Write("Customs Fee: ");
            decimal customsFee =
                decimal.Parse(Console.ReadLine());


            InternationalShipment internationalShipment =
                new InternationalShipment(
                    internationalTrackingCode,
                    internationalDescription,
                    internationalWeight,
                    internationalDeliveryFee,
                    destinationCountry,
                    customsFee
                );


            if (center.AddShipment(internationalShipment))
                Console.WriteLine("Shipment Added Successfully.");


            center.PrintAllShipments();


            Console.WriteLine();
            Console.Write("Enter Tracking Code to Search: ");

            string searchCode = Console.ReadLine();

            Shipment foundShipment = center[searchCode];

            if (foundShipment != null)
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Found:");

                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }




            Console.WriteLine();
            Console.Write("Enter Tracking Code to Remove: ");

            string removeCode = Console.ReadLine();

            bool removed = center.RemoveShipment(removeCode);

            if (removed)
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Not Found.");
            }


  

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("==========================================");

            center.PrintAllShipments();


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}