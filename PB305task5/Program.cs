#region task1
//int[] ededler = { 1, 2, 3, 4, 5, 6, 7, 8 };

//Console.Write("Tək ədədlər: ");
//for (int i = 0; i < ededler.Length; i++)
//{
//    if (ededler[i] % 2 != 0 && ededler[i] != 0)
//    {
//        Console.Write(ededler[i] + " ");
//    }

//}

//Console.WriteLine();

//Console.Write("Cüt ədədlər: ");
//for (int i = 0; i < ededler.Length; i++)
//{
//    if (ededler[i] % 2 == 0 && ededler[i] != 0)
//    {
//        Console.Write(ededler[i] + " ");
//    }
//}

//refactor:ustdeki kodu ise salanda tek ededler ve cut ededler ekrana ayriliqda cap edilir.
//indi ise basqa alqoritmle bunu yaziram

//int[] massiv = { 1, 2, 5, 8, 12, 13, 15, 17, 20, 22 };


//int[] tekler = new int[massiv.Length];
//int[] cutler = new int[massiv.Length];

//int tekIndex = 0;
//int cutIndex = 0;

//for (int i = 0; i < massiv.Length; i++)
//{
//    if (massiv[i] % 2 == 0)
//    {
//        cutler[cutIndex] = massiv[i];
//        cutIndex++;
//    }
//    else
//    {
//        tekler[tekIndex] = massiv[i];
//        tekIndex++;
//    }
//}

//Console.WriteLine("Cut ededler:");
//for (int i = 0; i < cutIndex; i++)
//{
//    Console.Write(cutler[i] + " ");
//}
//Console.WriteLine("              ");
//Console.WriteLine("Tek ededler:");
//for (int i = 0; i < tekIndex; i++)
//{
//    Console.Write(tekler[i] + " ");
//}



#endregion

#region task2
//int[] ededler = { 11, 2, 33, 44, 5, 6 };

//int cutIndexCemi = 0;
//int tekIndexCemi = 0;

//for (int i = 1; i < ededler.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        cutIndexCemi += ededler[i];
//    }
//    else
//    {
//        tekIndexCemi += ededler[i];
//    }
//}
//int ferq = (cutIndexCemi - tekIndexCemi);

//Console.WriteLine("Cut index cemi: " + cutIndexCemi);
//Console.WriteLine("Tek index cemi: " + tekIndexCemi);
//Console.WriteLine("Ferq: " + ferq);
#endregion

#region task3
//int[] ededler = { 1, 1, 1, 22, 22, 3, 66, 6, 66 };

//for (int i = 0; i < ededler.Length; i++)
//{
//    int say = 0;

//    for (int j = 0; j < ededler.Length; j++)
//    {
//        if (ededler[i] == ededler[j])
//        {
//            say++;
//        }
//    }

//    if (say == 1)
//    {
//        Console.Write(ededler[i] + " ");
//    }
//}

#endregion
