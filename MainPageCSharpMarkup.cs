using System;
using AppMarkupValidator.ViewModels;
using CommunityToolkit.Maui.Markup;

namespace AppMarkupValidator
{
    public class MainPageCSharpMarkup : ContentPage
    {

        int count = 0;
        public MainPageCSharpMarkup()
        {
            miViewModel vm = new miViewModel();

            // BindingContext = _vm = vm;
            BindingContext = vm;

            var mi_scrollView = new ScrollView();
            var mi_verticalStacklayout = new VerticalStackLayout
            {
                Spacing = 25,
                Children =
                {
                    new Label
                    {
                        Text="Hola a todos desde C# Markpu!",
                    }
                    .Font(size: 32).CenterHorizontal(),

                    new Label
                    {
                        Text="Bienvenido, probar validaciones",
                    }
                    .Font(size:18).CenterHorizontal(),

                    new Label
                    {
                        Text="Current count: 0",
                    }
                    .Font(size:18, bold:true).CenterHorizontal()
                    .Assign(out Label countLabel),

                    new Button
                    {
                        Text="Click me"
                    }
                    .Font(bold: true).CenterHorizontal()
                    .Invoke(b => b.Clicked += (sender, e) =>
                    {
                    count++;
                    countLabel.Text = $"Current count: {count}";

                    SemanticScreenReader.Announce(countLabel.Text);
                    }),

                   

                    // -----
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

