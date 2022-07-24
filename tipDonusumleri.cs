using System;

namespace console_programlama
{
    class pogram
    {
        static async void Main(string[] args)
        {
            // Inplicit Conversion (bilinçsiz dönüşüm)
            

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;

            Console.WriteLine("d:" + d );


            // Explicit Conversion (bilinçli dönüşüm)

            int x = 4;

            byte y =(byte)x;

            Console.WriteLine("y : " + y);


            // ToString methodu


        int xx =6;

        string yy = xx.ToString();
        Console.WriteLine("yy " + yy);


            //System.Convert


            string s1 ="10", s2 = "20";
            int sayi1 , sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1+sayi2;

            Console.WriteLine("toplam:" + toplam );

            // Parse

            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 ="10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("raam1:" + rakam1 );
            Console.WriteLine("double1:" + double1 );


            



        }
    }
}