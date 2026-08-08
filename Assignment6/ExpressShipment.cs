using Assignment5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    #region Three Shipment Types : ExpressShipment
    internal class ExpressShipment : Shipment
    {
        #region Attributes
        private decimal _extraFee;
        #endregion

        #region Properties
        public decimal ExtraFee
        {
            get { return _extraFee; }
            set
            {
                if (value >= 0)
                    _extraFee = value;
            }
        }

        public override double EstimatedCost
        {
            get
            {
                return (double)DeliveryFee + (double)(Weight * 5) + (double)_extraFee;
            }
        }
        #endregion

        #region constructors
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }


        #endregion

        #region Methods 
         
        public override void PrintShipment()
        {
            Console.WriteLine($"Our Shipment details is 1. Tracking code: {TrackingCode} \n 2.Description: {Description} \n 3.Weight: {Weight}kg \n 4.Delivery Fee: {DeliveryFee} EGP\n 5.Extra Fee: {ExtraFee} \n 6.Destination: {Destination.GetFullAddress()}\n 7.Estimated Cost: {EstimatedCost}EGP");
        }

        #endregion

    } 
    #endregion
}

