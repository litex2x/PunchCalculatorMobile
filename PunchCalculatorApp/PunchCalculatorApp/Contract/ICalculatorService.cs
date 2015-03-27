using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchCalculatorApp.Contract
{
    public interface ICalculatorService
    {
        DateTime Calculate(TimeSpan punchIn, TimeSpan lunchOut, TimeSpan lunchIn, int targetTotalMinutes, bool isOverriden);
    }
}
