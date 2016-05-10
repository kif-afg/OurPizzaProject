using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ImplentationPizzaProject.Annotations;
using ImplentationPizzaProject.Model;

namespace ImplentationPizzaProject.ViewModel
{
    class PizzaViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Pizza> plist;
        public PizzaCatalog pizzacatalog;
        public RelayCommand AddPizza;
        public string Type { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public string messageType { get; set; }
        public string messageQuantity { get; set; }
        public string messageSize { get; set; }


        public ObservableCollection<Pizza> Plist
        {
            get { return plist; }
            set
            {
                plist = value;
                OnPropertyChanged("Plist");
            }
        }

        public PizzaViewModel()
        {
            pizzacatalog = new PizzaCatalog();
            AddPizza = new RelayCommand(DoAddPizza);
        }

        public void DoAddPizza(object obj)
        {
            string t = Type;
            int q = Quantity;
            string s = Size;
            if (string.IsNullOrWhiteSpace(t))
            {
                messageType = "Type Can not be Empty";
                OnPropertyChanged("messageType");
            }

            else if (string.IsNullOrWhiteSpace(s))
            {
                messageSize = "Size Field Can not Be Empty";
                OnPropertyChanged("messageSize");
            }
            else
            {
                Plist.Add(pizzacatalog.CreatePizza(t, q, s));



            }

        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
