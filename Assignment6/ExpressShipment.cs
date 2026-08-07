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
        public ExpressShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        #endregion

    } 
    #endregion
}

