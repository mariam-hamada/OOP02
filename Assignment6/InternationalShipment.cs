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
        public InternationalShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customFee;
        }

        #endregion

    } 
    #endregion
}
