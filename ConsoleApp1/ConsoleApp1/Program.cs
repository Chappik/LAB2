
﻿// See https://aka.ms/new-console-template for more information





int a = 0, b = 0, vvod;



while (true)

{


    Console.WriteLine("1-Ввести A\n2-Ввести B\n3-Выполнить (+)\n4-Выполнить (-)\n5-Выполнить (*)\n6-Выполнить (/)");


    vvod = Convert.ToInt32(Console.ReadLine());




    if (vvod == 1)
    {
        Console.WriteLine("Введите A");


        a = Convert.ToInt32(Console.ReadLine());
    }

    


    if (vvod == 2)
    {


        Console.WriteLine("Введите B");


        b = Convert.ToInt32(Console.ReadLine());

    }




    if (vvod == 3)
    {


        Console.WriteLine(a + b);


    }




    if (vvod == 4)
    {


        Console.WriteLine(a - b);


    }


    if (vvod == 5)

    {


        Console.WriteLine(a * b);


    }













    if (vvod == 6)
    {


        Console.WriteLine(a / b);


    }




}


