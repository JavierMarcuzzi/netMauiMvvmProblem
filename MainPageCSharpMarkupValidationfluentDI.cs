namespace AppMarkupValidator
{
    // https://devblogs.microsoft.com/dotnet/announcing-net-maui-preview-12/#shell-and-dependency-injection
    public class MainPageCSharpMarkupValidationfluentDI : ContentPage
    {
        int count = 0;
        readonly vmPersona _vm;

        public MainPageCSharpMarkupValidationfluentDI(vmPersona vm)
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
                        Text="Validacion C# Markpu DI!",
                    }
                    .Font(size: 32).CenterHorizontal(),

                     new Label().Bind(Label.TextProperty, nameof(vm.Mensaje)),
                     new Label().Bind(Label.TextProperty, (nameof(vm.CanShow)).ToString()),
                      new Button()
                                 .Text("ver si esta forma anda")
                                 .BindCommand(nameof(vm.ShowCommand))
                                 .CenterHorizontal(),

                     new Entry()
                    {
                        Keyboard = Keyboard.Chat,
                        BackgroundColor = Colors.AliceBlue,
                    }.FontSize(15)
                    .Placeholder("Enter name")
                    .TextColor(Colors.Black)
                    .Height(44)
                    .Margin(5, 5)
                    .Bind(Entry.TextProperty, nameof(vm.Nombre)),

                     new Label().Bind(Label.TextProperty, nameof(vm.Nombre)),

                     new HorizontalStackLayout
                     {
                         Children=
                         {
                            new VerticalStackLayout
                             {
                                 Children=
                                {
                                    new Label {Text="First Name"},
                                    new Entry().FontSize(15)
                                    .Placeholder("First Name")
                                    .TextColor(Colors.Black)
                                    .Height(44)
                                    .Margin(5, 5)
                                    .Width(300)
                                    .Bind(Entry.TextProperty, nameof(vm.FirstName)),

                                    new Label().Bind(Label.TextProperty, nameof(vm.FirstName)),

                                }
                             },
                            new VerticalStackLayout
                             {
                                 Children=
                                {
                                    new Label {Text="Last Name"},
                                    new Entry()
                                    .FontSize(15)
                                    .Placeholder("last Name")
                                    .TextColor(Colors.Black)
                                    .Height(44)
                                    .Margin(5, 5)
                                    .Width(300)
                                    .Bind(Entry.TextProperty, nameof(vm.LastName)),

                                    new Label().Bind(Label.TextProperty, nameof(vm.LastName)),

                                  
                                }
                             }

                         }
                     }.CenterHorizontal(),
                         new VerticalStackLayout
                             {
                                 Children=
                                {
                                 new Button()
                                 .Text("try Save Valida Command")
                                 .BindCommand(nameof(vm.SaveValidaCommand))
                                 .CenterHorizontal()
                                }
                             },

                    new Label().Bind(Label.TextProperty, nameof(vm.FullName)),
                     new Label().Bind(Label.TextProperty, nameof(vm.FullNameValida)),


                    new Label{Text="Ver respuesta de Validación Fluent ....."}
                    .Font(size: 24, bold:true).CenterHorizontal(),

                    new Label{Text="ErrorMensajePasa", TextColor=Colors.BlueViolet},
                    new Label().Bind(Label.TextProperty, nameof(vm.ErrorMensajePasa)),
                     new Label{Text="ErrorMensajeGeneral", TextColor=Colors.BlueViolet},
                    new Label().Bind(Label.TextProperty, nameof(vm.ErrorMensajeGeneral)),
                     new Label{Text="FirtNameError", TextColor=Colors.BlueViolet},
                    new Label().Bind(Label.TextProperty, nameof(vm.FirtNameError)),
                     new Label{Text="LastNameError", TextColor=Colors.BlueViolet},
                    new Label().Bind(Label.TextProperty, nameof(vm.LastNameError)),


                    new Label{Text="Fin respuesta Validación, inicio para ver si anda el mvvm ..."}
                    .Font(size: 24, bold:true).CenterHorizontal(),

                    new Button()
                    .Text("Valida Excecute SingUpCommand")
                    .Font(bold: true)
                    .BindCommand(nameof(vm.ExecuteSignUpCommand))
                    .CenterHorizontal(),

                }
            }.Paddings(30, 30, 30, 30);

            mi_scrollView.Content = mi_verticalStacklayout;
            Content = mi_scrollView;
        }

    }

}