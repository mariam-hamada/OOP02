using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Assignment5
{
    #region  DeliveryCenter 
    internal class DeliveryCenter
    {
        #region Attributes
        private Shipment[] shipments = new Shipment[20];
        private string _centerName;

        #endregion

        #region Properties
        public string CenterName 
        {
            get { return _centerName; }
            set { _centerName = value; }
        }
        #endregion

        #region indexers
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];
                else
                    return null;

            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }

        public Shipment this[string trackingcode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingcode)
                        return shipments[i];
                return null;
            }
        }

        #endregion

        #region Methods
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            return false;
        } 

        public bool RemoveShipment(string _trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
                if (shipments[i] != null && shipments[i].TrackingCode == _trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
                if (shipments[i] != null)
                {
                    Console.WriteLine($"The details of Shipment{i + 1} is:");
                    shipments[i].PrintShipment();
                    Console.WriteLine("-------------------------------------");
                }
        }
        #endregion

    }

    #endregion
}
