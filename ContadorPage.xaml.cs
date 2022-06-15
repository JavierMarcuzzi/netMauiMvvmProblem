using AppMarkupValidator.ViewModels;

namespace AppMarkupValidator
{
    public partial class ContadorPage : ContentPage
    {
        public ContadorPage(miViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
