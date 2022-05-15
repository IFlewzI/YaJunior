using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            int overallPictures = 52;
            int rowSize = 3;
            int fullRows = overallPictures / rowSize;
            int picturesLeft = overallPictures % rowSize;

            Console.WriteLine("Заполненных рядов: {0}. \nКартинок осталось: {1}.", fullRows, picturesLeft);
        }
    }
}
