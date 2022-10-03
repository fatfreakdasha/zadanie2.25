using System;
using System.Collections.Generic;


{
    int second, fourth, sixth, eighth;
    Console.WriteLine("Введите число x:");
    second = Convert.ToInt32(Console.ReadLine());
    fourth = Convert.ToInt32(second / 166);
    sixth = Convert.ToInt32(second % 166);
    eighth = Convert.ToInt32((second * 10) + fourth);



    Console.WriteLine("Ответ:{0}", eighth );
    Console.ReadKey();
}


