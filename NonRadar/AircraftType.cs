using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRadar
{
   public class AircraftType
    {
        private int CLIMBRATE;
        private int DESCENDRATE;

        private int MAXSPEED;
        private int MINSPEED;
        private int SERVICECEILING;

        private int altitude;
        private int speed;

        public int AssignedAltitude { get; set; }
        public int AssignedSpeed { get; set; }

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
            if (alt <= SERVICECEILING)
            {
                AssignedAltitude = alt;
            }
        }

        public void assignSpeed(int speed)
        {
            if (speed > MINSPEED && speed < MAXSPEED)
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
