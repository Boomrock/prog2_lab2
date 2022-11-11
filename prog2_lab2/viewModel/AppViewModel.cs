using prog2_lab2.command;
using prog2_lab2.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace prog2_lab2.viewModel
{
    class AppViewModel : INotifyPropertyChanged
    {
        #region Value
        private List<GameImage> images;
        private Game game;
        GameImage selectedImage;
        #endregion 
        #region Command
        public Command Start { get; set; }
        public Command Mix { get; set; }
        public void start()
        {

            Images = Game.Start();


        }
        public void mix()
        {
            if(images != null)
                Images = Game.Mix(Images);
        }
        #endregion
        #region Property
        public Game Game
        {
            get
            {
                return game;
            }
            set
            {
                game = value;
            }
        }
        public GameImage SelectedImage
        {
            get
            {
                return selectedImage;

            }
            set
            {
                selectedImage = value;
                if (Game.IsMixed)
                {
                    selectedImage.IsSelected = true;
                    OnPropertyChanged("SelectedImage");
                }


            }
        }
        public List<GameImage> Images
        {
            get
            {
                return images;

            }
            set
            {
                images = value;
                OnPropertyChanged("Images");
            }
        }

        
        #endregion

        public AppViewModel()
        {
            Game = new Game(Loader.LoadImageFrom($"..\\..\\Images"));
            Start = new Command(start);
            Mix = new Command(mix);
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
