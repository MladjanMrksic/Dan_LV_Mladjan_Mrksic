using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanPizza.ViewModel
{
    class CreatePizzaViewModel : ViewModelBase
    {
        CreatePizzaView view;

        public CreatePizzaViewModel (CreatePizzaView cpv)
        {
            view = cpv;
        }


    }
}
