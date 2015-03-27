using PunchCalculatorApp.Contract;
using PunchCalculatorApp.Service;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace PunchCalculatorApp.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<ICalculatorService, CalculatorService>();
            SimpleIoc.Default.Register<CalculatorViewModel>();
        }

        public CalculatorViewModel Calculator
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CalculatorViewModel>();
            }
        }
    }
}
