using Assignment5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    #region Three Shipment Types : InternationalShipment
    internal class InternationalShipment : Shipment
    {
        #region Attributes
        private string _destinationCountry;
        private decimal _customsFee;

        #endregion

        #region Properties

        public string DestinationCountry
        {
            get { return _destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get { return _customsFee; }
            set
            {
                if (value >= 0)
                    _customsFee = value;
            }
        }

        public override double EstimatedCost
        {
            get
            {
                return (double)DeliveryFee + (double)(Weight * 5) + (double)CustomsFee;
            }
        }
        #endregion

        #region constructors
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customFee;
        }

        #endregion

        #region Ethods 
        public override void PrintShipment()
        {
            Console.WriteLine($"Our Shipment details is 1. Tracking code: {TrackingCode} \n 2.Description: {Description} \n 3.Weight: {Weight}kg \n 4.Delivery Fee: {DeliveryFee} EGP\n 5.Custom Fee: {CustomsFee} \n 6.Destiantion Country: {DestinationCountry}7.Destination: {Destination.GetFullAddress()}\n 8.Estimated Cost: {EstimatedCost}EGP");
        }
        #endregion

    } 
    #endregion
}
