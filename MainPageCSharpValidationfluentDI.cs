using System;
namespace AppMarkupValidator
{
	public class MainPageCSharpValidationfluentDI : ContentPage
	{
		readonly vmPersona _vm;

		public MainPageCSharpValidationfluentDI(vmPersona vm)
		{
			BindingContext = _vm = vm;

			var scrollView = new ScrollView();
			var verticalStackLayout = new VerticalStackLayout
			{
				Spacing = 25,
				Padding = 30,
			};

			scrollView.Content = verticalStackLayout;

			var tituloPagina = new Label
			{
				Text = "Hello from pure C# and mvvm!",
				FontSize = 32,
				HorizontalOptions = LayoutOptions.Center,
			};

			SemanticProperties.SetHeadingLevel(tituloPagina, SemanticHeadingLevel.Level1);
			verticalStackLayout.Children.Add(tituloPagina);

			var welcome = new Label
			{
				Text = "Welcome to Javier App UI",
				FontSize = 18,
				HorizontalOptions = LayoutOptions.Center,
			};

			SemanticProperties.SetHeadingLevel(welcome, SemanticHeadingLevel.Level1);
			SemanticProperties.SetDescription(welcome, "Welcome to dot net Multi platform App U I");

			verticalStackLayout.Children.Add(welcome);


			var EntradaNombre = new Entry()
			{
				Keyboard = Keyboard.Chat,
				BackgroundColor = Colors.AliceBlue,
				FontSize = 15,
				Placeholder = "Enter Name",
				TextColor = Colors.Black,
				HeightRequest = 44,
				Margin = 5
			};
			EntradaNombre.SetBinding(Entry.TextProperty, new Binding(nameof(vm.FirstName), BindingMode.OneWay));

			var LabelNombre = new Label() { Text= nameof(vm.FirstName)};

			verticalStackLayout.Children.Add(EntradaNombre);
			verticalStackLayout.Children.Add(LabelNombre);


			Content = scrollView;
		}
	}
}

