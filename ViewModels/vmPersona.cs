namespace AppMarkupValidator.ViewModels
{
    public partial class vmPersona : ObservableObject
    {
        public mPersona PersonaObj { get; set; }
        private readonly vPersona _validator;

        public vmPersona()
        {
            _validator = new vPersona();
        }

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(ExecuteSignUpCommand))]
       // [NotifyCanExecuteChangedFor(nameof(ExecuteSignUpCommand))]
        //  [AlsoNotifyChangeFor(nameof(MensajeValidaNombre))]
        string nombre;

        [ObservableProperty]
        //[NotifyPropertyChangedFor(nameof(FullName))]
         [AlsoNotifyChangeFor(nameof(FullName))]
        [AlsoNotifyChangeFor(nameof(valida))]
       // [NotifyCanExecuteChangedFor(nameof(ShowCommand))]
        private string firstName = string.Empty;

        [ObservableProperty]
        //[NotifyPropertyChangedFor(nameof(FullName))]
        [AlsoNotifyChangeFor(nameof(FullName))]
              [AlsoNotifyChangeFor(nameof(valida))]
       // [NotifyCanExecuteChangedFor(nameof(ShowCommand))]
        private string lastName = string.Empty;

        public string FullName => $"{FirstName} {LastName}";

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullNameValida))]
        [AlsoNotifyChangeFor(nameof(valida))]
        private string firstNameValida = string.Empty;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullNameValida))]
        [AlsoNotifyChangeFor(nameof(valida))]
        private string lastNameValida = string.Empty;

        public string FullNameValida => $"{FirstNameValida} {LastNameValida}";




      //  [RelayCommand(CanExecute = nameof(CanSaveExecute), IncludeCancelCommand = true)]
        [ICommand]
        private async Task SaveValidaAsync(CancellationToken cancelToken)
        {
            // Code to save the user details  ....  CanSaveExecute
            await Task.FromResult(0);
        }

        private bool CanSaveExecute()
      => !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName);

        [ObservableProperty]
        string errorMensajePasa = string.Empty;

        [ObservableProperty]
        string errorMensajeGeneral = string.Empty;


        [ObservableProperty]
        string firtNameError = string.Empty;

        [ObservableProperty]
        string lastNameError = string.Empty;

       
        [ICommand]
       // [RelayCommand]
        async Task ExecuteSignUpAsync()
        {
            await valida();
            
        }

        private async Task valida()
        {
            await Shell.Current.DisplayAlert("Probar botón!",
                   $"Parece que anda", "OK");

            PersonaObj = new mPersona
            {
                Name = FirstName,
                Surname = LastName
            };
            var validationResult = _validator.Validate(PersonaObj);
            if (validationResult.IsValid)
            {
                ErrorMensajePasa = "Validation Success..!!";
                ErrorMensajeGeneral = string.Empty;
            }
            else
            {
                ErrorMensajePasa = "Validation Failes..!!";

                ErrorMensajeGeneral = validationResult.ToString();

                //  var nError = validationResult.Errors.Where(e => e.PropertyName.Contains("Name"));
                var nError = validationResult.Errors.Where(e => e.PropertyName.Contains(nameof(PersonaObj.Name)));
                var sError = validationResult.Errors.Where(e => e.PropertyName.Contains("Surname"));

                foreach (var item in nError)
                {
                    FirtNameError = item.ErrorMessage + Environment.NewLine;
                }

                foreach (var item in sError)
                {
                    LastNameError = item.ErrorMessage + Environment.NewLine;
                }
            }
        }

        public bool CanShow { get => firstName.Length > 2 && lastName.Length > 2; }

        [ObservableProperty]
        string mensaje = string.Empty;

        [ICommand]
      //  [RelayCommand(CanExecute = nameof(CanShow))]
        private void Show()
        {
            //  MessageBox.Show(FullName);
            Mensaje = FullName;
        }

        //partial void OnFirstNameChanged(string value)
        //{
        //    if (CanShow)
        //    {
        //        //                MessageBox.Show($"Execute Custom code on {value}");
        //        Mensaje = $"Execute Custom code on {value}";
        //    }
        //}


    }

}