using prog2_lab2.command;
using prog2_lab2.models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace prog2_lab2.viewModel
{
    class AppViewModel : INotifyPropertyChanged
    {
       
        private ObservableCollection<BitmapImage> images;
        public Game game;

        public ObservableCollection<BitmapImage> Images { get => images; set => images = value; }

        public AppViewModel()
        {
            game = new Game(Loader.LoadImageFrom($"./Images"));
            Images = game.Start();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        //Метод, который скажет ViewModel, что нужно передать виду новые данные
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
