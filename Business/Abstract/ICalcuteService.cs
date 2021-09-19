using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICalcuteService
    {
        String TurnDirection(string PresentDirection, char TargetDirection);
        LocationVector RoverMove(LocationVector LocationVector);
        String LocationCalcute(LocationVector LocationVector, string Task);
    }
}
