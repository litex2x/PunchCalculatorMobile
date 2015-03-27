using Xamarin.Forms;

namespace PunchCalculatorApp.View
{
    public partial class CalculatorView : ContentPage
    {
        public CalculatorView()
        {
            InitializeComponent();
            BindingContext = App.Locator.Calculator;
        }
    }
}
