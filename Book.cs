using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask1422
{
    class Book : Product
    {
        public string Genre;


        public Book()
        {

        }
        public Book(string name, string genre)
        {
            if (Name == "" || Name == " " || Genre == "" || Genre == " ")
            {
                Console.WriteLine("Melumatlar duzgun daxil edilmeyib.");
            }
            Name = name;
            Genre = genre;
        }

        public void AddCount(int count)
        {
            Console.WriteLine("Kitab sayini daxil edin.");
            count = Convert.ToInt32(Console.ReadLine());
            while (count <= 0)
            {
                Console.WriteLine("Duzgun say daxil etmemisiniz.");
                if (count <= 0)
                {

                    Console.WriteLine("Yeniden cehd edin:");
                    count = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine($" Daxil olundu:{count}");


            Count = count;
        }


        public void AddBook()
        {
            Console.WriteLine($"Kitabin  xarakteristikalarini  daxil edin:");

            Book[] books = new Book[Count];
            for (int i = 0; i <= Count; i++)
            {
                books[i] = new Book();
                Console.WriteLine($"Ad:");
                books[i].Name = Console.ReadLine();
                Console.WriteLine($" Janr:");
                books[i].Genre = Console.ReadLine();
                Console.WriteLine($" No:");
                books[i].No = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($" Qiymet:");
                books[i].Price = Convert.ToInt32(Console.ReadLine());
                while (i < Count - 1)
                {
                    Console.WriteLine("Novbeti kitab:");
                    break;
                }
            }

           
            int secim = 0;
            while (secim != 0)
            {

                Console.WriteLine("Sechiminizi edin:");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)


                {
                    case 1:
                        Console.WriteLine("Kitablari qiymete gore filterle.");
                        Console.WriteLine("Minimum qiymeti daxil et:");
                        int Min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Maximum qiymeti daxil et:");
                        int Max = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 2:
                        Console.WriteLine("Butun kitablari goster:");
                        foreach (var item in books)
                        {
                            Console.WriteLine($"Ad: {Name}  No: {No}  Janr: {Genre}  Price: {Price}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Program basha chatdi");
                        break;
                    default:

                        Console.WriteLine("Duzgun say daxil etmemisiniz.");
                        while (secim <= 0)
                        {

                            Console.WriteLine("Yeniden cehd edin:");
                            secim = Convert.ToInt32(Console.ReadLine());

                        }
                        break;

                }
            }          

                     
            


        }
    }
}
