namespace AppMarkupValidator.ViewModels
{
    public partial class miViewModel : ObservableObject
    {
        [ObservableProperty]
        int count;

        [ICommand]
       // [RelayCommand]
        void IncrementCount() => Count++;
        // {
        //     Count += 10;
        // }

    }


}


