using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace NewTopics.ViewModels
{
    public class CustomizableLabelViewModel : BaseViewModel
    {
        public ICommand OpenWebCommand { get; }

        public CustomizableLabelViewModel()
        {
            Title = "Customizable Label";

            OpenWebCommand = new Command<String>((uri) => Device.OpenUri(new Uri(uri)));
        }
    }
}
