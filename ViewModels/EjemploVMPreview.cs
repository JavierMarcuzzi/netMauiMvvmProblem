using System;
//namespace AppMarkupValidator.ViewModels
//{
//    [INotifyPropertyChanged]
//    public partial class EjemploVMPreview
//	{
		
//        //[ObservableProperty]
//        //[AlsoNotifyChangeFor(nameof(FullName))]
//        //[AlsoNotifyCanExecuteFor(nameof(ShowCommand))]
//        //private string firstName = string.Empty;

//        //[ObservableProperty]
//        //[AlsoNotifyChangeFor(nameof(FullName))]
//        //[AlsoNotifyCanExecuteFor(nameof(ShowCommand))]
//        //private string lastName = string.Empty;

//        //public string FullName => $"{LastName} {FirstName}";
//        //public bool CanShow { get => firstName.Length > 2 && lastName.Length > 2; }

//        //[ICommand(CanExecute = nameof(CanShow))]
//        //private void Show()
//        //{
//        //    MessageBox.Show(FullName);
//        //}

//        //partial void OnFirstNameChanged(string value)
//        //{
//        //    if (CanShow)
//        //    {
//        //        MessageBox.Show($"Execute Custom code on {value}");
//        //    }
//        //}

//        [ObservableProperty]
//        [NotifyPropertyChangedFor(nameof(FullName))]
//        [NotifyCanExecuteChangedFor(nameof(ShowCommand))]
//        private string firstName = string.Empty;

//        [ObservableProperty]
//        [NotifyPropertyChangedFor(nameof(FullName))]
//        [NotifyCanExecuteChangedFor(nameof(ShowCommand))]
//        private string lastName = string.Empty;

//        public string FullName => $"{LastName} {FirstName}";

//        public bool CanShow { get => firstName.Length > 2 && lastName.Length > 2; }

//        [ObservableProperty]
//        string mensaje = string.Empty;

//      //  [ICommand(CanExecute = nameof(CanShow))]
//        [RelayCommand(CanExecute = nameof(CanShow))]
//        private void Show()
//        {
//            //  MessageBox.Show(FullName);
//            Mensaje = FullName;
//        }

//        partial void OnFirstNameChanged(string value)
//        {
//            if (CanShow)
//            {
//                //                MessageBox.Show($"Execute Custom code on {value}");
//                Mensaje = $"Execute Custom code on {value}";
//            }
//            else
//            {
//                Mensaje = String.Empty;
//            }
//        }
//    }
   
//}

