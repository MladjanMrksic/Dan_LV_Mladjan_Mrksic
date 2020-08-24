using PanPizza.ViewModel;
using System.Windows;

namespace PanPizza
{
    public partial class CreatePizzaView : Window
    {
        public CreatePizzaView()
        {
            DataContext = new CreatePizzaViewModel(this);
            InitializeComponent();
        }
    }
}
