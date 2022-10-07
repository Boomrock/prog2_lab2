using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace prog2_lab2.viewModel
{
    class AppViewModel
    {
        private ObservableCollection<GameImage> images;
        public GameImage SelectedImages;

        public ObservableCollection<GameImage> Images { get => images; set => images = value; }

        public AppViewModel()
        {
            Images = new ObservableCollection<GameImage>()
            {
                new GameImage( new BitmapImage(new Uri($"C:\\Users\\федор\\Downloads\\ismail-inceoglu-gifts-of-the-immensity.jpg")))
            };
        }
    }
}
