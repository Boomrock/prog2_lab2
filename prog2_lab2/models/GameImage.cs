using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace prog2_lab2
{
    class GameImage : INotifyPropertyChanged
    {

        private BitmapImage image;
        
        private string color;
        private bool isСhosen;
        private bool isSelected;
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
                OnPropertyChanged("Color");
                OnPropertyChanged("isSelected");

            }
        }



        public string Color
        {
            get
            {

                if (isSelected && isСhosen)
                {
                    return "Green";
                }
                else if (isSelected && !isСhosen)
                {

                    return "Red";
                }
                return "Black";
               
            }
            set
            {
                color = value;
               
                OnPropertyChanged("Color");
            }
        }
        public bool IsСhosen
        {
            get
            {
                return isСhosen;
            }
            set
            {
                this.isСhosen = value;
                OnPropertyChanged("IsСhosen");
            }
        }
        public BitmapImage Image { get => image; }



        public GameImage(BitmapImage Image)
        {
            this.image = Image;
            this.isСhosen = false;
            this.color = "Black";

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
