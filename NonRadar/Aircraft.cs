using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRadar
{
    class Aircraft
    {
        public string Callsign { get; }
        private AircraftType acType;

        private int altitude;
        private int speed;

        private int assignedAltitude;
        private int assignedSpeed;

        public int AssignedAltitude
        {
            get { return assignedAltitude; }
            set
            {
                if (value <= acType.SERVICECEILING && value > 012)
                {
                    assignedAltitude = value;
                }
                else
                {
                    //TODO
                }
            }
        }
        public int AssignedSpeed
        {
            get { return assignedSpeed; }
            set
            {
                if (value <= acType.MAXSPEED && value >= acType.MINSPEED)
                {
                    assignedSpeed = value;
                }
                else
                {
                    //TODO
                }
            }
        }


        public void Update()
        {
            if (AssignedAltitude != altitude)
            {
                updateAltitue();
            }

            if (AssignedSpeed != speed)
            {
                updateSpeed();
            }

            updatePosition();
        }


        public void assignAltitude(int alt)
        {
            if (alt <= acType.SERVICECEILING)
            {
                AssignedAltitude = alt;
            }
        }

        public void assignSpeed(int speed)
        {
            if (speed > acType.MINSPEED && speed < acType.MAXSPEED)
            {
                AssignedSpeed = speed;
            }
        }

        public void updateSpeed()
        {
            //TODO
        }

        public void updateAltitue()
        {
            //TODO implement w/ sim loop
        }

        public void updatePosition()
        {

        }
    }
}
