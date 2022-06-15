namespace AppMarkupValidator.ViewModels
{
    [INotifyPropertyChanged]
    public partial class DateViewModel //: ObservableObject
    {
		//public DateViewModel()
		//{
		//}

        public DateViewModel()
        {
            Title = "Date Calculation";
            StartDate = DateTime.Today;
            EndDate = DateTime.Today;
            DiffMode = true;
            SelectedMode = string.Empty;

            Range = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                Range.Add(i);
            }

            FindTheDate();
        }

        [ObservableProperty]
        private DateTime startDate;

        [ObservableProperty]
        private DateTime endDate;

        [ObservableProperty]
       // [NotifyPropertyChangedFor(nameof(DiffModeInverse))]
        [AlsoNotifyChangeFor(nameof(DiffModeInverse))]
        private bool diffMode;

        [ObservableProperty]
        private int selectedYear;

        [ObservableProperty]
        private int selectedMonth;

        [ObservableProperty]
        private int selectedDay;

        [ObservableProperty]
        private string resultCaption = string.Empty;

        [ObservableProperty]
        private string diffResult = string.Empty;

        [ObservableProperty]
        private string diffInDays = string.Empty;

        [ObservableProperty]
        private int option;

        [ObservableProperty]
        private string selectedMode = string.Empty;

        [ObservableProperty]
      //  [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        [AlsoNotifyChangeFor(nameof(IsNotBusy))]
        private bool isBusy;

        [ObservableProperty]
        private bool isNotBusy;

        [ObservableProperty]
        private bool canLoadMore;

        [ObservableProperty]
        private string? title = string.Empty;

        [ObservableProperty]
        private string? subtitle = string.Empty;

        [ObservableProperty]
        private string? icon = string.Empty;

        [ObservableProperty]
        private string? header = string.Empty;

        [ObservableProperty]
        private string? footer = string.Empty;

        [ObservableProperty]
        private bool isValid = true;

        [ObservableProperty]
        private List<string> errors = new();

     

        public IList<int> Range { get; init; }

        public bool DiffModeInverse => !DiffMode;

 

         void OnDiffModeChanged(bool value)
        {
            if (value)
            {
                ResultCaption = "Difference";
                SelectedMode = string.Empty;
            }
            else
            {
                ResultCaption = "Date";
                SelectedMode = "Add";
            }
        }

         void OnOptionChanged(int value) => DiffMode = value == 0;

         void OnStartDateChanged(DateTime value) => FindTheDate();

         void OnEndDateChanged(DateTime value) => FindTheDate();

         void OnSelectedModeChanged(string value) => FindTheDate();

         void OnSelectedYearChanged(int value) => FindTheDate();

         void OnSelectedMonthChanged(int value) => FindTheDate();

         void OnSelectedDayChanged(int value) => FindTheDate();

       // [RelayCommand]
        [ICommand]
        private void DateDiff() => FindTheDate();

        private void FindTheDate()
        {
            if (DiffMode)
            {
                var dtStart = StartDate;
                var dtEnd = EndDate;

                // If the startDate is later than the endDate, then swap their values
                if (StartDate > EndDate)
                {
                    dtStart = EndDate;
                    dtEnd = StartDate;
                }

             //   DiffResult = Utility.DateDiff(dtStart, dtEnd);
             //   DiffInDays = ((int)(dtEnd - dtStart).TotalDays).InWords(TimeUnit.Day);
            }
            else
            {
                int factor = 1;

                if (SelectedMode == "Subtract")
                {
                    factor = -1;
                }

                DiffResult = StartDate.AddYears(SelectedYear * factor)
                                      .AddMonths(SelectedMonth * factor)
                                      .AddDays(SelectedDay * factor)
                                      .ToLongDateString();
                DiffInDays = string.Empty;
            }
        }
    }
}

