using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRadar
{
    public class Aircraft
    {
        public string Callsign { get; }
        public AircraftType acType { get; }

        private int altitude;
        private int speed;
        private float ATD;

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
                UpdateAltitude();
            }

            if (AssignedSpeed != speed)
            {
                UpdateSpeed();
            }

            updatePosition();
        }


        public void AssignAltitude(int alt)
        {
            if (alt <= acType.SERVICECEILING)
            {
                AssignedAltitude = alt;
            }
        }

        public void AssignSpeed(int speed)
        {
            if (speed > acType.MINSPEED && speed < acType.MAXSPEED)
            {
                AssignedSpeed = speed;
            }
        }

        private void UpdateSpeed()
        {
            //TODO
        }

        private void UpdateAltitude()
        {
            if (altitude > AssignedAltitude * 100)
            {
                altitude -= (int)((float)acType.DESCENDRATE / 60);
                if (altitude < AssignedAltitude * 100)
                    altitude = AssignedAltitude * 100;
            }
            else
            {
                altitude += (int)((float)acType.CLIMBRATE / 60);
                if (altitude > AssignedAltitude * 100)
                    altitude = AssignedAltitude * 100;
            }
        }

        public void updatePosition()
        {
            ATD += (float)speed / 3600;
        }
    }
}
