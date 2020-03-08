using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CustomerMVVM.Model
{
    public class Customer : INotifyPropertyChanged
    {
        public Customer(String CustomerName)
        {
            Name = CustomerName;
        }


        public string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value;
              }
        }

        //private void OnPropertyChanged(string v)
        //{
        //    throw new NotImplementedException();
       // }

        private readonly INotifyPropertyChanged Members;
public event PropertyChangedEventHandler PropertyChanged;
    }
}
