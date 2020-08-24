using PanPizza.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PanPizza.ViewModel
{
    class CreatePizzaViewModel : ViewModelBase
    {
        CreatePizzaView view;

        public CreatePizzaViewModel (CreatePizzaView cpv)
        {
            view = cpv;
        }
        private int total;
        public int Total
        {
            get { return total; }
            set { total = value; OnPropertyChanged("Total"); }
        }


        private string pizzaSize;
        public string PizzaSize
        {
            get { return pizzaSize; }
            set { pizzaSize = value; OnPropertyChanged("PizzaSize"); }
        }

        private bool bologna;
        public bool Bologna
        {
            get { return bologna; }
            set
            {
                bologna = value; OnPropertyChanged("Bologna");
            }
        }
        private bool ham;
        public bool Ham
        {
            get { return ham; }
            set { ham = value; OnPropertyChanged("Ham");}
        }
        private bool kulen;
        public bool Kulen
        {
            get { return kulen; }
            set { kulen = value; OnPropertyChanged("Kulen"); }
        }
        private bool ketchup;
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; OnPropertyChanged("Ketchup"); }
        }
        private bool mayonnaise;
        public bool Mayonnaise
        {
            get { return mayonnaise; }
            set { mayonnaise = value; OnPropertyChanged("Mayonnaise"); }
        }
        private bool hotPepper;
        public bool HotPepper
        {
            get { return hotPepper; }
            set { hotPepper = value; OnPropertyChanged("HotPepper"); }
        }
        private bool olive;
        public bool Olive
        {
            get { return olive; }
            set { olive = value; OnPropertyChanged("Olive"); }
        }
        private bool oregano;
        public bool Oregano
        {
            get { return oregano; }
            set { oregano = value; OnPropertyChanged("Oregano"); }
        }
        private bool sesame;
        public bool Sesame
        {
            get { return sesame; }
            set { sesame = value; OnPropertyChanged("Sesame"); }
        }
        private bool cheese;
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; OnPropertyChanged("Cheese"); }
        }

        private ICommand close;
        public ICommand Close
        {
            get
            {
                if (close == null)
                {
                    close = new RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }
                return close;
            }
        }
        private void CloseExecute()
        {
            try
            {
                view.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex.Message.ToString());
            }
        }
        private bool CanCloseExecute()
        {
            return true;
        }

        private ICommand newOrder;
        public ICommand NewOrder
        {
            get
            {
                if (newOrder == null)
                {
                    newOrder = new RelayCommand(param => NewOrderExecute(), param => CanNewOrderExecute());
                }
                return newOrder;
            }
        }
        private void NewOrderExecute()
        {
            try
            {
                CreatePizzaView newView = new CreatePizzaView();
                newView.Show();
                view.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex.Message.ToString());
            }
        }
        private bool CanNewOrderExecute()
        {
            return true;
        }

        private ICommand printBill;
        public ICommand PrintBill
        {
            get
            {
                if (printBill == null)
                {
                    printBill = new RelayCommand(param => PrintBillExecute(), param => CanPrintBillExecute());
                }
                return printBill;
            }
        }
        private void PrintBillExecute()
        {
            try
            {
                Total = 0;
                switch (PizzaSize)
                {
                    case "Small":
                        Total += 100;
                        break;
                    case "Medium":
                        Total += 150;
                        break;
                    case "Large":
                        Total += 200;
                        break;
                }
                if (Bologna == true) Total += 5;
                if (Ham == true) Total += 7;
                if (Kulen == true) Total += 9;
                if (Ketchup == true)Total += 2;
                if (Mayonnaise == true) Total += 2;
                if (HotPepper == true) Total += 5;
                if (Olive == true) Total += 5;
                if (Oregano == true)Total += 2;
                if (Sesame == true)Total += 3;
                if (Cheese == true) Total += 8;

                view.cmbPizzaSize.IsEnabled = false;
                view.Bologna.IsEnabled = false;
                view.Ham.IsEnabled = false;
                view.Kulen.IsEnabled = false;
                view.Ketchup.IsEnabled = false;
                view.Mayonnaise.IsEnabled = false;
                view.HotPepper.IsEnabled = false;
                view.Olive.IsEnabled = false;
                view.Oregano.IsEnabled = false;
                view.Sesame.IsEnabled = false;
                view.Cheese.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex.Message.ToString());
            }
        }
        private bool CanPrintBillExecute()
        {
            if (PizzaSize != null && Bologna == true || Ham == true || Kulen == true || Ketchup == true || Mayonnaise == true || HotPepper == true || Olive == true || Oregano == true || Sesame == true || Cheese == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
