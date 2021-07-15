using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleProject.View.Custom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomEntryCell : ViewCell
    {
        public static readonly BindableProperty TextForEntryProperty =
            BindableProperty.Create(
                propertyName: nameof(TextForEntry),
                returnType: typeof(string),
                declaringType: typeof(CustomEntryCell),
                defaultValue: "Example TextForEntry");

        public CustomEntryCell()
        {
            InitializeComponent();
        }

        public string TextForEntry
        {
            get { return (string)GetValue(TextForEntryProperty); }
            set { SetValue(TextForEntryProperty, value); }
        }
    }
}