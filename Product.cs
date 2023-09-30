using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogApp
{
    internal class Product : INotifyPropertyChanged
    {
        private string name;
        private string category;
        private decimal price;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Category
        {
            get { return category; }
            set
            {
                if (category != value)
                {
                    category = value;
                    OnPropertyChanged("Category");
                }
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged("Price");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
