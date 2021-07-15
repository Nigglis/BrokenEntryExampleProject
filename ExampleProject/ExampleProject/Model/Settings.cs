using Xamarin.Essentials;

namespace ExampleProject.Model
{
    public static class Settings
    {
        private const string KeyFirstEntry = "firstEntry";
        private static readonly string FirstEntryDefault = "Empty 1";
        private const string KeySecondEntry = "secondEntry";
        private static readonly string SecondEntryDefault = "Empty 2";
        private const string KeyThirdEntry = "thirdEntry";
        private static readonly string ThirdEntryDefault = "Empty 3";
        private const string KeyFourthEntry = "fourthEntry";
        private static readonly string FourthEntryDefault = "Empty 4";
        private const string KeyFifthEntry = "fifthEntry";
        private static readonly string FifthEntryDefault = "Empty 5";
        private const string KeySixthEntry = "sixthEntry";
        private static readonly string SixthEntryDefault = "Empty 6";
        private const string KeySeventhEntry = "seventhEntry";
        private static readonly string SeventhEntryDefault = "Empty 7";

        public static string FirstEntry
        {
            get { return Preferences.Get(KeyFirstEntry, FirstEntryDefault); }
            set { Preferences.Set(KeyFirstEntry, value); }
        }
        public static string SecondEntry
        {
            get { return Preferences.Get(KeySecondEntry, SecondEntryDefault); }
            set { Preferences.Set(KeySecondEntry, value); }
        }
        public static string ThirdEntry
        {
            get { return Preferences.Get(KeyThirdEntry, ThirdEntryDefault); }
            set { Preferences.Set(KeyThirdEntry, value); }
        }
        public static string FourthEntry
        {
            get { return Preferences.Get(KeyFourthEntry, FourthEntryDefault); }
            set { Preferences.Set(KeyFourthEntry, value); }
        }
        public static string FifthEntry
        {
            get { return Preferences.Get(KeyFifthEntry, FifthEntryDefault); }
            set { Preferences.Set(KeyFifthEntry, value); }
        }
        public static string SixthEntry
        {
            get { return Preferences.Get(KeySixthEntry, SixthEntryDefault); }
            set { Preferences.Set(KeySixthEntry, value); }
        }
        public static string SeventhEntry
        {
            get { return Preferences.Get(KeySeventhEntry, SeventhEntryDefault); }
            set { Preferences.Set(KeySeventhEntry, value); }
        }
    }
}
