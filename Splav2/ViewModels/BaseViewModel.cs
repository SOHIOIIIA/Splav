﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForModel.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged

    {

        public event PropertyChangedEventHandler PropertyChanged;

        public bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)

        {

            if (Equals(storage, value)) return false;

            storage = value;

            RaisePropertyChanged(propertyName);

            return true;

        }
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
