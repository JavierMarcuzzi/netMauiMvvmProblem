

namespace AppMarkupValidator
{
    // https://devblogs.microsoft.com/dotnet/announcing-net-maui-preview-12/#shell-and-dependency-injection

    public class MainPageCSharpMarkupDI : ContentPage
    {
        int count = 0;
        readonly miViewModel _vm;

        public MainPageCSharpMarkupDI(miViewModel vm)
        {
            BindingContext = _vm = vm;

            var mi_scrollView = new ScrollView();
            var mi_verticalStacklayout = new VerticalStackLayout
            {
                Spacing = 25,
                Children =
                {
                    new Label
                    {
                        Text="Hola a todos desde C# Markpu DI!",
                    }
                    .Font(size: 32).CenterHorizontal(),

                    new Label {Text="Ver si anda"}.Font(size: 24, bold:true).CenterHorizontal(),

                    new Label()
                        .Font(size: 18, bold: true)
                        .CenterHorizontal()
                        .Bind<Label, int, string>(Label.TextProperty, nameof(vm.Count), convert: count => $"Current Count: {count}"),

                    new Button()
                        .Text("Click Me")
                        .Font(bold: true)
                        .BindCommand(nameof(vm.IncrementCountCommand))
                        .CenterHorizontal(),
                }
            }.Paddings(30, 30, 30, 30);

            mi_scrollView.Content = mi_verticalStacklayout;
            Content = mi_scrollView;
        }
    }
}

