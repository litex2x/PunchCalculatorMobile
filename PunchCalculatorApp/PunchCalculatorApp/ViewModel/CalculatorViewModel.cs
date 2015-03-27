using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using PunchCalculatorApp.Contract;
using GalaSoft.MvvmLight.Command;

namespace PunchCalculatorApp.ViewModel
{
    public class CalculatorViewModel : ViewModelBase
    {
        private ICalculatorService calculatorService;

        private TimeSpan punchIn;
        public TimeSpan PunchIn
        {
            get
            {
                return punchIn;
            }

            set
            {
                punchIn = value;
                RaisePropertyChanged("PunchIn");
            }
        }

        private TimeSpan lunchOut;
        public TimeSpan LunchOut
        {
            get
            {
                return lunchOut;
            }

            set
            {
                lunchOut = value;
                RaisePropertyChanged("LunchOut");
            }
        }

        private TimeSpan lunchIn;
        public TimeSpan LunchIn
        {
            get
            {
                return lunchIn;
            }

            set
            {
                lunchIn = value;
                RaisePropertyChanged("LunchIn");
            }
        }

        private string result;
        public string Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
                RaisePropertyChanged("Result");
            }
        }

        private int targetTotalMinutes;
        public int TargetTotalMinutes
        {
            get
            {
                return targetTotalMinutes;
            }

            set
            {
                targetTotalMinutes = value;
                RaisePropertyChanged("TargetTotalMinutes");
            }
        }

        private bool isOverridden;
        public bool IsOverridden
        {
            get
            {
                return isOverridden;
            }

            set
            {
                isOverridden = value;
                RaisePropertyChanged("IsOverridden");
            }
        }

        public ICommand CalculateCommand { protected set; get; }

        public CalculatorViewModel(ICalculatorService service)
        {
            calculatorService = service;
            CalculateCommand = new RelayCommand(Calculate);
            PunchIn = new TimeSpan(8, 0, 0);
            LunchOut = new TimeSpan(12, 0, 0);
            LunchIn = new TimeSpan(12, 30, 0);
            TargetTotalMinutes = 480;
        }

        private void Calculate()
        {
            try
            {
                var punchOut = calculatorService.Calculate(PunchIn, LunchOut, LunchIn, TargetTotalMinutes, IsOverridden);

                Result = string.Format("Punch out at {0:h:mm tt}.", punchOut);
            }
            catch (ArgumentException exception)
            {
                Result = exception.Message;
            }
        }

        private bool CanCalculate()
        {
            return TargetTotalMinutes < 0;
        }
    }
}
