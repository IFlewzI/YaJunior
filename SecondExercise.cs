using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            string userName;
            string userFavoriteBook;
            string userLocation;
            short userAge;
            short userCountOfChromosomes;

            Console.Write("Здравствуйте, дорогой пользователь, присаживайтесь. Как вас зовут? ");
            userName = Console.ReadLine();
            Console.Write("Очень приятно, {0}, а можно узнать, сколько вам лет? ", userName);
            userAge = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ага, понятно. У меня что-то данные со спутников барахлят. Можно также уточнить город, в котором вы живёте? " +
                "Очень уж важная информация) ");
            userLocation = Console.ReadLine();
            Console.Write("{0}, интересненько... Ну раз уж у нас началось интервью, то мне интересно, {1}, " +
                "а какая у вас любимая книга? ", userLocation, userName);
            userFavoriteBook = Console.ReadLine();
            Console.Write("Ааааа, помню, читал её как-то. Сложная довольно-таки. Вот сколько у вас хромосом? Хватило, чтобы её прочитать?) ");
            userCountOfChromosomes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Так, то есть давай подрезюмируем. Вас зовут {0}, вам {1} лет и вы живёте в городе {2}. " +
                "У вас {3} хромосомы, а ваша любимая книга это {4}. " +
                "Ничего не напутал?", userName, userAge, userLocation, userCountOfChromosomes, userFavoriteBook);
        }
    }
}
