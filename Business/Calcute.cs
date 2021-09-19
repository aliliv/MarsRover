using Business.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class Calcute : ICalcuteService
    {
        public string TurnDirection(string PresentDirection, char TargetDirection) {
            //Find Directions Dictionary PresentDirection Key
            int PresentDirectionKey = Direction.Directions.FirstOrDefault(x => x.Value == PresentDirection).Key;
            if (TargetDirection == 'L')
            {
                if (PresentDirectionKey > 1)
                    PresentDirectionKey--;
                else
                    PresentDirectionKey = 4;
            }
            else if (TargetDirection == 'R')
            {
                if (PresentDirectionKey < 4)
                    PresentDirectionKey++;
                else
                    PresentDirectionKey = 1;
            }
            return Direction.Directions[PresentDirectionKey];
        }
        public LocationVector RoverMove(LocationVector LocationVector)
        {
            if (LocationVector.Direction == "N")
            {
                LocationVector.LocationY = LocationVector.LocationY+1;
            }
            else if (LocationVector.Direction == "E")
            { 
                LocationVector.LocationX = LocationVector.LocationX+1;
            }
            else if (LocationVector.Direction == "S")
            {
                LocationVector.LocationY = LocationVector.LocationY-1;
            }
            else if (LocationVector.Direction == "W")
            {
                LocationVector.LocationX = LocationVector.LocationX-1;
            }
            return LocationVector;
        }

        public string LocationCalcute(LocationVector LocationVector, string Task)
        {
            for (int i = 0; i < Task.Count(); i++)
            {
                if (Task[i] == 'L' || Task[i] == 'R')
                {
                    LocationVector.Direction= TurnDirection(LocationVector.Direction, Task[i]);
                }
                else if(Task[i] == 'M')
                {
                    LocationVector=RoverMove(LocationVector);
                }
            }
            return LocationVector.LocationX + " " + LocationVector.LocationY + " " + LocationVector.Direction;
        }
    }
}
