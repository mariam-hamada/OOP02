using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    #region Shipment class
    internal class Shipment
    {
        #region Attributes
        private string _trackingCode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;
        private DeliveryAddress _destination;
        #endregion

        #region Properties
        public string TrackingCode
        {
            get { return _trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _trackingCode = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _description = value;
            }
        }

        public decimal Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                    _weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return _deliveryFee;
            }
            private set
            {
                if (value > 0)
                    _deliveryFee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                _destination = value;
            }
        }

        public virtual double EstimatedCost
        {
            get
            {
                return (double)(_deliveryFee + (_weight * 5));
            }
        }
        #endregion

        #region constructor overloading

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Cairo", "Tahrir", 10);
        }

        public Shipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = (decimal)weight;
            DeliveryFee = (decimal)deliveryFee;
            Destination = destination;
        }
        #endregion

        #region  methods 

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee =newFee;
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Our Shipment details is 1. Tracking code: {_trackingCode} \n 2.Description: {_description} \n 3.Weight: {_weight} \n 4.Delivery Fee: {_deliveryFee} \n 5.Destination: {_destination}\n 6.Estimated Cost: {EstimatedCost}");
        }
        #endregion
    }
    #endregion
}
