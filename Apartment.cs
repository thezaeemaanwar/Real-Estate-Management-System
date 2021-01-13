using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management
{
    class Apartment
    {
        //every apartment should have an unique ID
        public string ID { get; }
        private string description;
        private float perceivedValue;
        private float materialsPrice;
        private float workForcePrice;
        private float currentExpenditure;
        private int squareMeters;
        private int noRooms;
        private bool metroProximity;
        private int perceivedComfort;
        private string zone;

        public Apartment(string desc, float pVal, float mPrice, float wfPrice,float cExpenditure, int sqMeter,int nRooms, bool mProximity, int pComfort, string zone)
        {
            Guid guid = Guid.NewGuid();
            this.ID = guid.ToString();
            this.description = desc;
            this.perceivedValue = pVal;
            this.materialsPrice = mPrice;
            this.workForcePrice = wfPrice;
            this.currentExpenditure = cExpenditure;
            this.squareMeters = sqMeter;
            this.noRooms = nRooms;
            this.metroProximity = mProximity;
            this.perceivedComfort = pComfort;
            this.zone = zone;
        }
    }
}
