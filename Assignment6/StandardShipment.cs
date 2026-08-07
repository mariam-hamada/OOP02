using Assignment5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    #region Three Shipment Types : StandardShipment

    internal class StandardShipment : Shipment
    {
        #region constructors
        public StandardShipment(string TrackingCode) : base(TrackingCode) { }
        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination) { }

        #endregion
    } 
    #endregion
}
