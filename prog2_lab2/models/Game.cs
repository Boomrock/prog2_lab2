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
        public bool IsMixed; 
        public Game(List<BitmapImage> bitmapImages)
        {
            gameImages = new List<GameImage>();
            foreach (BitmapImage item in bitmapImages)
            {
                gameImages.Add(new GameImage(item));
            }
            IsMixed = false; 
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
                if (images.Count > 50) break;

            }
            ArrayMethods<GameImage>.Shuffle(images);
            IsMixed = false; 
            return images;
        }
        public List<GameImage> Mix(List<GameImage> images)
        {
            if(IsMixed)
                return images;
            if (images == null)
                throw new ArgumentNullException(nameof(images));

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
                if (newlistImages.Count > 50) break;

            }
            IsMixed = true; 
            ArrayMethods<GameImage>.Shuffle(images);
            return newlistImages;
        }
    }
}
