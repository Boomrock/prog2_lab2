using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab2.models
{
    class ArrayMethods<type>
    {
        
        public static void Shuffle(List<type> list)
        {
            // создаем экземпляр класса Random для генерирования случайных чисел
            Random rand = new Random();

            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                type tmp = list[j];
                list[j] = list[i];
                list[i] = tmp;
            }
        }
    }
}
