using CodePound.PunchOutCalculator.NovaLogic;
using PunchCalculatorApp.Contract;
using System;

namespace PunchCalculatorApp.Service
{
    class CalculatorService : ICalculatorService
    {
        public DateTime Calculate(TimeSpan punchIn, TimeSpan lunchOut, TimeSpan lunchIn, int targetTotalMinutes, bool isOverriden)
        {
            DateTime punchInDt = DateTime.Now.Date.Add(punchIn);
            DateTime lunchOutDt = DateTime.Now.Date.Add(lunchOut);
            DateTime lunchInDt = DateTime.Now.Date.Add(lunchIn);
            PunchCruncher punchCruncher = new PunchCruncher(punchInDt, lunchOutDt, lunchInDt, targetTotalMinutes, isOverriden);

            return punchCruncher.GetPunchOut();
        }
    }
}
