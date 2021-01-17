using System;



class Program
{
    static void Main()
    {

        Console.WriteLine("Lütfen isminizi giriniz");
        string Adi = Console.ReadLine();

        Console.WriteLine("Lütfen soyadınızı  giriniz");
        string Soyadi = Console.ReadLine();

        Console.WriteLine("Merhaba {0} {1}", Adi, Soyadi);
        //Console.WriteLine("Merhaba " + KullaniciAdi);
    }
}

//----------------------------------------------------------------------

using System;



class Program
{
    static void Main()
    {

        Console.WriteLine("Min={0}", int.MinValue);
        Console.WriteLine("Max={0}", int.MaxValue);
        double d = 23.12121221;
        Console.WriteLine(d);

        //----------------------------

        string Name = "Erdoğan";
        Console.WriteLine(Name);

        //---------------------------------

        int num1 = 10;
        int num2 = 2;
        int result = num1 / num2;
        Console.WriteLine("result ={0}", result);

        //----------------------------------

        int num1 = 10;
        if (num1 == 10)
        {
            Console.WriteLine("ahahahah");
        }

        //-------------------------------------

        bool ? ErkekMi = true;
        if (ErkekMi == true)
        {
            Console.WriteLine("Kişi erkektir");
        }
        else if (ErkekMi == false)
        {
            Console.WriteLine("Kişi erkek değildir.");
        }
        else
        {
            Console.WriteLine("Kişi cevap vermedi");
        }


        //------------------------------------------------------

        int ? satilanBiletler = 100;

        int satilmayanBiletler = satilanBiletler ?? 0;

        Console.WriteLine("Satılmayan biletler = {0}", satilmayanBiletler);

        //----------------------------------------------
        int i = 100;
        float f = i;
        Console.WriteLine(f);

        //---------------------------------------------------

        float f = 123.45F;
        int i = (int)f;
        Console.WriteLine(i);

        //---------------------------------------------

        string strNumber = "100";   //String'i integer yapma
        int i = int.Parse(strNumber);
        Console.WriteLine(i);

        //----------------------------------------------------

        //DİZİLERRRR:

        int[] EvenNumbers = new int[3];
        EvenNumbers[0] = 6;
        EvenNumbers[1] = 8;
        EvenNumbers[2] = 10;

        Console.WriteLine(EvenNumbers[1]);

        //-----------------------------------------------------

        Console.WriteLine("Please enter a number");

        int num = int.Parse(Console.ReadLine());
        if (num == 1)
        {
            Console.WriteLine("Your number is one");

        }
        else if (num == 2)
        {
            Console.WriteLine("Your number is two");
        }
        else if (num == 3)
        {
            Console.WriteLine("Your number is three");
        }
        else
        {
            Console.WriteLine("Your number is not between 1 and 3");
        }

        //------------------------------------------------------------

        Console.WriteLine("Please enter a number");
        int num = int.Parse(Console.ReadLine());
        if (num == 10 && num == 20)
        {
            Console.WriteLine("your number  is 10 or 20");
        }
        else
        {
            Console.WriteLine("Your number is not 10 or 20");
        }

        //-----------------------------------------------------------------


        Console.WriteLine("Please enter a number");

        int num = int.Parse(Console.ReadLine());


        switch (num)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your number is {0}", num);
                break;
            default:
                Console.WriteLine("None of them..");
                break;
        }


        //------------------------------------------------------------

        int TotalCoffeCost = 0;
    Start:
        Console.WriteLine("1-Small,2-Medium,3-Large");

        int UserChoice = int.Parse(Console.ReadLine());

        switch (UserChoice)
        {
            case 1:
                TotalCoffeCost += 1;
                break;

            case 2:
                TotalCoffeCost += 2;
                break;

            case 3:
                TotalCoffeCost += 3;
                break;

            default:
                Console.WriteLine("Your choice{0} is invalid");
                goto Start;
        }
    Decision:

        Console.WriteLine("Do you want another coffe - Y or N?");
        string UserDecision = Console.ReadLine();
        switch (UserDecision.ToUpper())
        {
            case "Y":
                goto Start;

            case "N":
                break;

            default:
                Console.WriteLine("Your choice{0} is invalid", UserDecision);
                goto Decision;
        }

        Console.WriteLine("Thanks for shopping");
        Console.WriteLine("Bill amount ={0}", TotalCoffeCost);


        //-----------------------------------------------------------------


         Console.WriteLine("Please enter a number");
        int number = int.Parse(Console.ReadLine());

        int Start = 0;
        while (Start <= number)
        {
            Console.WriteLine(Start);
            Start += 2;
        }

        //------------------------------------------------------------------

        int[] numbers = new int[3];
        numbers[0] = 101;
        numbers[1] = 102;
        numbers[2] = 103;


        for (int j = 0; j < numbers.Length; j++)
        {
            Console.WriteLine(numbers[j]);
        }

        int i = 0;
        while (i < numbers.Length)
        {
            Console.WriteLine(numbers[i]);
            i++;
        }

        //------------------------------------------------------
        int[] numbers = new int[3];
        numbers[0] = 101;
        numbers[1] = 102;
        numbers[2] = 103;

        foreach (int k in numbers)
        {
            Console.WriteLine(k);
        }

        //--------------------------------------------------

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
            if (i == 10)
                break;

        }

        //----------------------------------------------------------------







    }

}