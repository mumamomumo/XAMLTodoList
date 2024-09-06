using TodoListAppThingButItDoesntWork.ViewModel;

namespace TodoListAppThingButItDoesntWork
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

    }
}
