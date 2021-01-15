using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management
{
    public class Apartment
    {
        public string ID { get; }
        public string description{ get; }
        public float perceivedValue{ get; }
        public float materialsPrice{ get; }
        public float workForcePrice{ get; }
        public float currentExpenditure{ get; }
        public int squareMeters{ get; }
        public int noRooms{ get; }
        public bool metroProximity{ get; }
        public int perceivedComfort{ get; }
        public string zone{ get; }

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
        public Apartment(string id, string desc, float pVal, float mPrice, float wfPrice, float cExpenditure, int sqMeter, int nRooms, bool mProximity, int pComfort, string zone)
        {
            this.ID = id;
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
