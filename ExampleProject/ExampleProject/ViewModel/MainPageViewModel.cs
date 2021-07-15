using ExampleProject.Model;
using System.ComponentModel;
using System.Diagnostics;

namespace ExampleProject.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        public MainPageViewModel() { }

        public string _firstEntry = Settings.FirstEntry;
        public string _secondEntry = Settings.SecondEntry;
        public string _thirdEntry = Settings.ThirdEntry;
        public string _fourthEntry = Settings.FourthEntry;
        public string _fifthEntry = Settings.FifthEntry;
        public string _sixthEntry = Settings.SixthEntry;
        public string _seventhEntry = Settings.SeventhEntry;

        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties
        public string FirstEntry
        {
            get { return _firstEntry; }
            set
            {
                _firstEntry = value.ToString();
                UpdateFirstEntry(_firstEntry);
                OnPropertyChanged(nameof(FirstEntry));
            }
        }
        public string SecondEntry
        {
            get { return _secondEntry; }
            set
            {
                _secondEntry = value.ToString();
                UpdateSecondEntry(_secondEntry);
                OnPropertyChanged(nameof(SecondEntry));
            }
        }
        public string ThirdEntry
        {
            get { return _thirdEntry; }
            set
            {
                _thirdEntry = value.ToString();
                UpdateThirdEntry(_thirdEntry);
                OnPropertyChanged(nameof(ThirdEntry));
            }
        }
        public string FourthEntry
        {
            get { return _fourthEntry; }
            set
            {
                _fourthEntry = value.ToString();
                UpdateFourthEntry(_fourthEntry);
                OnPropertyChanged(nameof(FourthEntry));
            }
        }
        public string FifthEntry
        {
            get { return _fifthEntry; }
            set
            {
                _fifthEntry = value.ToString();
                UpdateFifthEntry(_fifthEntry);
                OnPropertyChanged(nameof(FifthEntry));
            }
        }
        public string SixthEntry
        {
            get { return _sixthEntry; }
            set
            {
                _sixthEntry = value.ToString();
                UpdateSixthEntry(_sixthEntry);
                OnPropertyChanged(nameof(SixthEntry));
            }
        }
        public string SeventhEntry
        {
            get { return _seventhEntry; }
            set
            {
                _seventhEntry = value.ToString();
                UpdateSeventhEntry(_seventhEntry);
                OnPropertyChanged(nameof(SeventhEntry));
            }
        }
        #endregion

        private void UpdateFirstEntry(string value) => Settings.FirstEntry = value;
        private void UpdateSecondEntry(string value) => Settings.SecondEntry = value;
        private void UpdateThirdEntry(string value) => Settings.ThirdEntry = value;
        private void UpdateFourthEntry(string value) => Settings.FourthEntry = value;
        private void UpdateFifthEntry(string value) => Settings.FifthEntry = value;
        private void UpdateSixthEntry(string value) => Settings.SixthEntry = value;
        private void UpdateSeventhEntry(string value) => Settings.SeventhEntry = value;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
