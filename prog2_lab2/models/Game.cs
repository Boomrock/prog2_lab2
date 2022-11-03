using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace prog2_lab2.models
{
    class Game
    {
        List<GameImage> gameImages; 
        public Game(List<BitmapImage> bitmapImages)
        {
            gameImages.Clear();
            foreach (BitmapImage item in bitmapImages)
            {
                gameImages.Add(new GameImage(item));
            }
        }
        public List<GameImage> Start()
        {
            Random random = new Random();
            List<GameImage> images = new List<GameImage>();
            foreach (GameImage item in gameImages)
            {
                item.IsСhosen = false;
                if (random.Next(0,9) <= 3)
                {
                    images.Add(item);
                    item.IsСhosen = true;
                }
            }
            return images;
        }
        public List<GameImage> Mix(List<GameImage> images)
        {
            Random random = new Random();
            List<GameImage> newlistImages = new List<GameImage>();
            foreach (GameImage image in images)
            {
                foreach (GameImage gameImage in gameImages)
                {

                    if (random.Next(0, 9) <= 2)
                    {
                        newlistImages.Add(gameImage);
                    }
                }
                newlistImages.Add(image);

            }
            return images;
        }

    }
}
