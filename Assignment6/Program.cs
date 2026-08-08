using Assignment5;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Question 1

            //a) What is the difference between a class and a struct?
            //class:is a refrence type stored in heap, when Assignment it copies the refrence, support inhertance ,can be null , default constructor is available if none is defined, suitable for complex programs.
            //struct:is a value type stored in stack,  when assignment it copies the value, deosn't support inhertance ,cannot be null, default constructor is available all time, suitable for simple program.

            //b) Why are classes more suitable than structs for large application
            //Because classes support complex program as it support inhertance and avoids unnecessaray coping.
            #endregion

            #region Question 2

            //a) Which class is the parent class?
            //Shipment

            //b) Which class is the child class?
            //ExpressShipment

            //c) What members are inherited by ExpressShipment?
            //TrackingCode

            //d) Why is inheritance better than duplicating the same code in multiple classes?
            //Inheritance promotes code reuse, reduces duplication, makes the code easier to maintain, and allows common functionality to be defined once in the parent class and reused by multiple child classes.

            #endregion
            #endregion

            #region Part 02 : Practical Smart Delivery Management System

            #region Create Delivery Center

            DeliveryCenter deliveryCenter = new DeliveryCenter();

            Console.WriteLine("Hello,");
            Console.Write("Please enter the Center Name: ");
            deliveryCenter.CenterName = Console.ReadLine();

            #endregion

            #region Standard Shipment Data

            Console.WriteLine();
            Console.WriteLine("Please enter the Standard shipment data:");

            Console.Write("Please enter the Tracking code: ");
            string standardTrackingCode = Console.ReadLine();

            Console.Write("Please enter the Description: ");
            string standardDescription = Console.ReadLine();

            Console.Write("Please enter the Weight: ");
            decimal.TryParse(Console.ReadLine(), out decimal standardWeight);

            Console.Write("Please enter the Delivery Fee: ");
            decimal.TryParse(Console.ReadLine(), out decimal standardDeliveryFee);

            Console.Write("Please enter the City: ");
            string standardCity = Console.ReadLine();

            Console.Write("Please enter the Street: ");
            string standardStreet = Console.ReadLine();

            Console.Write("Please enter the Building number: ");
            int.TryParse(Console.ReadLine(), out int standardBuildingNumber);

            DeliveryAddress standardDeliveryAddress =
                new DeliveryAddress(
                    standardCity,
                    standardStreet,
                    standardBuildingNumber);

            StandardShipment standardShipment =
                new StandardShipment(
                    standardTrackingCode,
                    standardDescription,
                    standardWeight,
                    standardDeliveryFee,
                    standardDeliveryAddress);

            #endregion

            #region Express Shipment Data

            Console.WriteLine();
            Console.WriteLine("Please enter the Express shipment data:");

            Console.Write("Please enter the Tracking code: ");
            string expressTrackingCode = Console.ReadLine();

            Console.Write("Please enter the Description: ");
            string expressDescription = Console.ReadLine();

            Console.Write("Please enter the Weight: ");
            decimal.TryParse(Console.ReadLine(), out decimal expressWeight);

            Console.Write("Please enter the Delivery Fee: ");
            decimal.TryParse(Console.ReadLine(), out decimal expressDeliveryFee);

            Console.Write("Please enter the City: ");
            string expressCity = Console.ReadLine();

            Console.Write("Please enter the Street: ");
            string expressStreet = Console.ReadLine();

            Console.Write("Please enter the Building number: ");
            int.TryParse(Console.ReadLine(), out int expressBuildingNumber);

            Console.Write("Please enter the Extra Fee: ");
            decimal.TryParse(Console.ReadLine(), out decimal expressExtraFee);

            DeliveryAddress expressDeliveryAddress =
                new DeliveryAddress(
                    expressCity,
                    expressStreet,
                    expressBuildingNumber);

            ExpressShipment expressShipment =
                new ExpressShipment(
                    expressTrackingCode,
                    expressDescription,
                    expressWeight,
                    expressDeliveryFee,
                    expressDeliveryAddress,
                    expressExtraFee);

            #endregion

            #region International Shipment Data

            Console.WriteLine();
            Console.WriteLine("Please enter the International shipment data:");

            Console.Write("Please enter the Tracking code: ");
            string interTrackingCode = Console.ReadLine();

            Console.Write("Please enter the Description: ");
            string interDescription = Console.ReadLine();

            Console.Write("Please enter the Weight: ");
            decimal.TryParse(Console.ReadLine(), out decimal interWeight);

            Console.Write("Please enter the Delivery Fee: ");
            decimal.TryParse(Console.ReadLine(), out decimal interDeliveryFee);

            Console.Write("Please enter the City: ");
            string interCity = Console.ReadLine();

            Console.Write("Please enter the Street: ");
            string interStreet = Console.ReadLine();

            Console.Write("Please enter the Building number: ");
            int.TryParse(Console.ReadLine(), out int interBuildingNumber);

            Console.Write("Please enter the Destination country: ");
            string interDestinationCountry = Console.ReadLine();

            Console.Write("Please enter the Custom Fee: ");
            decimal.TryParse(Console.ReadLine(), out decimal interCustomFee);

            DeliveryAddress interDeliveryAddress =
                new DeliveryAddress(
                    interCity,
                    interStreet,
                    interBuildingNumber);

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    interTrackingCode,
                    interDescription,
                    interWeight,
                    interDeliveryFee,
                    interDeliveryAddress,
                    interDestinationCountry,
                    interCustomFee);

            #endregion


            #region Add Shipments

            Console.WriteLine();

            if (deliveryCenter.AddShipment(standardShipment))
            {
                Console.WriteLine("Shipment added successfully");
            }

            if (deliveryCenter.AddShipment(expressShipment))
            {
                Console.WriteLine("Shipment added successfully");
            }

            if (deliveryCenter.AddShipment(internationalShipment))
            {
                Console.WriteLine("Shipment added successfully");
            }

            #endregion


            #region Print All Shipments

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine($"Delivery Center : {deliveryCenter.CenterName}");
            Console.WriteLine("==========================================");

            deliveryCenter.PrintAllShipments();

            #endregion


            #region Search Shipment

            Console.WriteLine();
            Console.Write("Please enter the tracking code for the shipment you want to search for: ");
            string searchTrackingCode = Console.ReadLine();

            Shipment searchShipment = deliveryCenter[searchTrackingCode];

            if (searchShipment != null)
            {
                Console.WriteLine("Shipment founded successfully");
                searchShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not founded");
            }

            #endregion

            #region Remove Shipment

            Console.WriteLine();
            Console.Write("Please enter the tracking code for the shipment you want to delete: ");
            string deleteTrackingCode = Console.ReadLine();

            if (deliveryCenter.RemoveShipment(deleteTrackingCode))
            {
                Console.WriteLine("Shipment deleted successfully");
            }
            else
            {
                {
                    Console.WriteLine("Shipment not founded");
                }
            }
            #endregion

            #region Print Remaining Shipments

                Console.WriteLine();
                Console.WriteLine("The remaining shipments");
                Console.WriteLine("----------------------------------");

                deliveryCenter.PrintAllShipments();

                #endregion
            #endregion



          
        }
    }
}
