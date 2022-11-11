using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;

namespace prog2_lab2.models
{
    internal class Loader
    {
        internal static List<BitmapImage> LoadImageFrom(string path )
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            List<BitmapImage> Images = new List<BitmapImage>(); //ваш лист с Bitmap
            foreach (var file in directoryInfo.GetFiles()) //проходим по файлам
            {
                //получаем расширение файла и проверяем подходит ли оно нам 
                if (file.Extension == ".jpg" || file.Extension == ".png")
                    Images.Add(new BitmapImage(new Uri(file.FullName))); //если расширение подошло, создаём Bitmap
            }
            return Images;
        }
    }
}