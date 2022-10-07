﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace prog2_lab2
{
    class GameImage : INotifyPropertyChanged
    {

        private BitmapImage image;
        private bool isСhosen;
        public GameImage(BitmapImage image)
        {
            this.image = image;
        }
        public bool IsСhosen
        {
            get
            {
                return isСhosen;
            }
            set
            {
                this.isСhosen = IsСhosen;
                OnPropertyChanged("isСhosen");
            }
        }

        public BitmapImage Image { get => image;}

        public event PropertyChangedEventHandler PropertyChanged;
        //Метод, который скажет ViewModel, что нужно передать виду новые данные
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    
}