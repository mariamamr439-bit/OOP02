namespace OOP02
{
    // ==========================================
    // Delivery Center
    // ==========================================
    public class DeliveryCenter
    {
        private string centerName;

        private Shipment[] shipments;

        private int shipmentCount;


        public string CenterName
        {
            get { return centerName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    centerName = value;
            }
        }


        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;

            shipments = new Shipment[20];

            shipmentCount = 0;
        }


        // ==========================================
        // Integer Indexer
        // ==========================================
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipmentCount)
                    return shipments[index];

                return null;
            }

            set
            {
                if (index >= 0 && index < shipmentCount)
                {
                    shipments[index] = value;
                }
            }
        }


        // ==========================================
        // String Indexer
        // ==========================================
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipmentCount; i++)
                {
                    if (shipments[i] != null &&
                        shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }


        // ==========================================
        // Add Shipment
        // ==========================================
        public bool AddShipment(Shipment shipment)
        {
            if (shipment == null)
                return false;

            if (shipmentCount >= shipments.Length)
                return false;

            shipments[shipmentCount] = shipment;

            shipmentCount++;

            return true;
        }


        // ==========================================
        // Remove Shipment
        // ==========================================
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipmentCount; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    // Shift remaining shipments
                    for (int j = i; j < shipmentCount - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }

                    shipments[shipmentCount - 1] = null;

                    shipmentCount--;

                    return true;
                }
            }

            return false;
        }


        // ==========================================
        // Print All Shipments
        // ==========================================
        public void PrintAllShipments()
        {
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine("==========================================");

            for (int i = 0; i < shipmentCount; i++)
            {
                shipments[i].PrintShipment();

                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
            }
        }
    }
}