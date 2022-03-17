using System;

namespace Consolee
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*  Console.WriteLine("Yashini daxil et");
               byte age = Convert.ToByte(Console.ReadLine());
             Console.WriteLine("ili daxil et");
               int year = Convert.ToInt32(Console.ReadLine());
               for (int i = age; i >0;i--)
                { 
                   Console.WriteLine(year - i + " -ci ilde " + (age -i) + " yasin var ");
              //  }


                 Console.WriteLine("Yashini yeniden daxil et");
               byte age1 = Convert.ToByte(Console.ReadLine());
               Console.WriteLine("ili yeniden daxil et");
               int year1 = Convert.ToInt32(Console.ReadLine());
                for (int i = year1 - age1; i <= year1; ++i)
                 {
                    Console.WriteLine(i + " -ci ilde " + Math.Abs((year1 - age1-i)) + " yasin var ");
                }*/
            #endregion
            #region
            /*   Console.WriteLine("Kredit goturenin yasi: ");
               byte age = Convert.ToByte(Console.ReadLine());
               Console.WriteLine("ayliq maasin meblegi: ");
               int salary = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Istediyi kreditin meblegi: ");
               int credit = Convert.ToInt32(Console.ReadLine());
               if (age >= 18 && age <= 50 && credit <= (salary*7.2))
               {
                   Console.WriteLine("Yashiniz sertleri odediyine gore Size kredit verile biler");
               }
               else if(age > 50 && credit <= (salary*8.4))
               {
                   Console.WriteLine("Yashiniz sertleri odediyine gore Size kredit verile biler");
               }
               else
               {
                   Console.WriteLine("Kredit Verilmir");
               }
            */
            #endregion
            #region
            //int begin = Convert.ToInt32(Console.ReadLine());
            //int final = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //if (begin < final)
            //{
            //    for (int i = begin; i < final; i++)
            //    {
            //        sum += i;
            //    }
            //    Console.WriteLine(sum);
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            //    int n = Convert.ToInt32(Console.ReadLine());
            //    int cem = 0, i;
            //    int say = 0;
            //    for (i = 15; i < n; i+=15)
            //    {
            //         cem += i;
            //        say++;
            //    }
            //    Console.WriteLine(cem / say);
            #endregion
            #region
            //int n = Convert.ToInt32(Console.ReadLine());
            //int say = 1;
            //if (n < 0)
            //    n *= 1;
            //while (n > 10)
            //{
            //    say++;
            //    n /= 10;
            //}
            //Console.WriteLine(say + " mertebelidir.");
            #endregion
            #region
            //bool f = false;
            //int start = Convert.ToInt32(Console.ReadLine());
            //int end = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("bolunecekEded daxil edin: ");
            //int bolunecekEded = Convert.ToInt32(Console.ReadLine());
            //if (start < end)
            //{
            //    for (int i = bolunecekEded; i < end; i += bolunecekEded)
            //    {
            //        if (i % bolunecekEded == 0)
            //        {
            //            f = true;
            //        }
            //        else
            //        {
            //            f = false;
            //        }
            //    }
            //    if (f == true)
            //    {
            //        Console.WriteLine("Var");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yoxdur");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}
            #endregion
            #region
            //int num = Convert.ToInt32(Console.ReadLine());
            //int say = 0;
            //if (num > 0)
            //{
            //    while (num > 0)
            //    {
            //        if (num % 2 == 0)
            //        {
            //            say++;
            //            num /= 2;
            //        }else
            //        {
            //            Console.WriteLine("False");
            //        }
            //    }
            //    Console.WriteLine(say);
            //}
            //else
            //{
            //    Console.WriteLine("Menfi ola bilmez");
            //}
            #endregion
            #region
            //int first = 0, second = 1, third = 0;
            //int fibonacci = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < fibonacci; i++)
            //{
            //    Console.WriteLine(third);
            //    first = second;
            //    second = third;
            //    third = first + second;
            //}
            #endregion
            #region
            //int[] bubble = new int[] { 99, 54, 21, 48, 45, 32, 11 };
            //int example = 0;
            //for (int i = 0; i < bubble.Length; i++)
            //{
            //    for (int j = 0; j < bubble.Length - 1; j++)
            //    {
            //        if (bubble[j] > bubble[j + 1])
            //            example = bubble[j];
            //        bubble[j] = bubble[j + 1];
            //        bubble[j + 1] = example;
            //    }
            //}
            //for (int j = 0; j < bubble.Length; j++)
            //{
            //    Console.WriteLine(bubble[j]);
            //}
            #endregion
            #region
            //int[] change = new int[] { 1, 2, 3, 4, 5 };
            //int max = 0, min = 0;
            //for (int i = 1; i < change.Length; i++)
            //{
            //    if (change[i] > change[max])
            //    {
            //        max = i;
            //    }
            //    else if (change[i] < change[min])
            //    {
            //        min = i;
            //    }
            //}
            //for (int i = 0; i < change.Length; i++)
            //{


            //    change[max] = change[max] + change[min];
            //    change[min] = change[max] - change[min];
            //    change[max] = change[max] + change[min];
            //}
            //for (int i = 0; i < change.Length; i++)
            //{
            //    Console.WriteLine(change[i]);
            //}
            #endregion
            #region
            //string text = Console.ReadLine();
            //string temp = "";
            //foreach (char letter in text)
            //{
            //    if (letter == 'a')
            //    {
            //        temp += 'e';
            //    }
            //    else
            //    {
            //        temp += letter;
            //    }
            //    text = temp;
            //}
            //Console.WriteLine(text);
            #endregion
            #region
            //string text = Console.ReadLine();
            //string vowel = "aeiouüəöı";
            //int count = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int j = 0; j < vowel.Length; j++)
            //    {
            //        if (text[i] == vowel[j])
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine(count);
            #endregion
            #region MyRegion

            // BubbleWithMethod(5,3,4,5,6,8,6,1,0);


            //int res = Digit(-255);
            //Console.WriteLine(res);




            //int netice = LowestNumInArray(100, 5, 3, 4, 2, 1, 6, 7);
            //Console.WriteLine(netice);
            //Console.WriteLine(MNSum(1, 3));

            //   Console.WriteLine(power(18));
            //Console.WriteLine(Text("s sdsd   sdsd "));
            #endregion
            #region UsingOut
            int[] nums = { 1, 2, 3 };
            int average;
            AverageArray(nums, out average);
            Console.WriteLine(average);
            #endregion
        }
        #region AverageWithOut
        static void AverageArray(int[] num, out int avr)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                count++;
                sum += num[i];
            }
            avr = sum / count;
        }

        #endregion
        #region BubbleWithMethod
        //static void BubbleWithMethod(params int[] bubble)
        //{
        //    bool f = false;
        //    int temp = 0;
        //    for (int i = 0; i < bubble.Length; i++)
        //    {
        //        f = false;
        //        for (int j = 0; j < bubble.Length - 1; j++)
        //        {
        //            if (bubble[j] > bubble[j + 1])
        //            {
        //                f = true;
        //                temp = bubble[j];
        //                bubble[j] = bubble[j + 1];
        //                bubble[j + 1] = temp;
        //            }
        //        }
        //        if (!f)
        //        {
        //            break;
        //        }
        //    }
        //    for (int i = 0; i < bubble.Length; i++)
        //    {
        //        Console.WriteLine(bubble[i]);
        //    }
        #endregion
        #region DigitCount
        //static int Digit(int m)
        //{
        //    int count = 1;
        //    if (m < 0)
        //    {
        //        m *= (-1);
        //    }
        //    while (m > 9)
        //    {

        //        count++;
        //        m /= 10;
        //    }

        //    return count;
        //}
        #endregion
        #region LowestNumInArray
        //static int LowestNumInArray(params int[] num)
        //{
        //    int lowestindex = 0;
        //    for (int i = 1; i < num.Length; i++)
        //    {
        //        if (num[lowestindex] > num[i])
        //        {
        //            lowestindex = i;
        //        }
        //    }
        //    return lowestindex;

        #endregion
        #region SumFromMtoN
        //static bool IsBigger(int m, int n)
        //{
        //    if (m > n) return true;
        //    else return false;
        //}
        //static int MNSum(int m, int n)
        //{
        //    int sum = 0;
        //    if (IsBigger(m, n))
        //    {
        //        Console.WriteLine("M ededi N-den boyuk ola bilmez");
        //    }
        //    else
        //    {
        //        for (int i = m; i < n; i++)
        //        {
        //            sum += i;
        //        }
        //    }
        //    return sum;
        #endregion
        #region PowerWordCount
        //static int power(int n)
        //{
        //    int count = 0;
        //    if (n % 2 == 0)
        //    {
        //        while (n > 1)
        //        {
        //            n /= 2;
        //            count++;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("2-nin quvveti deyil");
        //    }
        //    return count;
        //}
        //static int Text(string text)
        //{
        //    int count = 1;
        //    for (int i = 0; i < text.Length-1; i++)
        //    {
        //        if (text[i] == ' '&& text[i+1]!=' ')
        //        count++;
        //    }
        //    return count;
        //}
        #endregion
    }
}