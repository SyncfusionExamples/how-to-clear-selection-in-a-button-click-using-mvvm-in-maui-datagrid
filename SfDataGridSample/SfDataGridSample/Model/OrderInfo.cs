using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int orderID;
        private string customerID;
        private string freight;
        private string country;

        public int OrderID
        {
            get { return orderID; }
            set 
            { 
                orderID = value;
                RaisePropertyChanged(nameof(orderID));
            }
        }
        public string CustomerID
        {
            get { return customerID; }
            set
            {
                customerID = value;
                RaisePropertyChanged(nameof(customerID));
            }
        }

        public string Freight
        {
            get { return freight; }
            set
            {
                freight = value;
                RaisePropertyChanged(nameof(freight));
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                RaisePropertyChanged(nameof(country));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if(this.PropertyChanged!=null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
