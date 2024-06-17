using System.Reflection.Metadata;

namespace methodCalculator;

class Program
{
    static void Main(string[] args)
    {







        while (true)
        {



            Console.WriteLine("1. Toplama\n2. Çıxma\n3. Vurma\n4. Bölmə\n5. Üst alma\n6. Çıxış");
            Console.WriteLine("zehmet olmasa secim edin");
            int secim = int.Parse(Console.ReadLine());



            if (secim == 1)
            {
                Toplama();
            }


            else if (secim == 2)
            {
                Cixma();
            }

            else if (secim == 3)
            {
                Vurma();
            }

            else if (secim == 4)
            {
                Bolme();
            }



            else if (secim==5)
            {
                Ustalma();
            }

            else if (secim==6)
            {
                Console.WriteLine("Sonlandirildi");

                break;

            }

            else
            {
                Console.WriteLine("duzgun secim daxil edin");
            }
        }

    }


        public static void Toplama()
        {
            Console.WriteLine("eded1 daxil edin");

            double eded1 = double.Parse(Console.ReadLine());

            Console.WriteLine("eded2 daxil edin");

            double eded2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Cem: " + (eded1 + eded2));

        }

        public static void Cixma()
        {

            Console.WriteLine("eded1 daxil edin");

            double eded1 = double.Parse(Console.ReadLine());

            Console.WriteLine("eded2 daxil edin");

            double eded2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Cixma: " + (eded1 - eded2));


        }

        public static void Vurma()
        {

            Console.WriteLine("eded1 daxil edin");

            double eded1 = double.Parse(Console.ReadLine());

            Console.WriteLine("eded2 daxil edin");

            double eded2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Vurma: " + (eded1 * eded2));


        }

           public static void Bolme()
        {

        
            Console.WriteLine("eded1 daxil edin");

            double eded1 = double.Parse(Console.ReadLine());

            Console.WriteLine("eded2 daxil edin");

            double eded2 = double.Parse(Console.ReadLine());
        if (eded2==0)
        {
            Console.WriteLine("0 a bolmek olmaz");
            return;
        }


            Console.WriteLine("Bolme: " + (eded1 / eded2));


        }



    public static void Ustalma()
    {


        Console.WriteLine("ededi daxil edin");

        double eded = double.Parse(Console.ReadLine());

        Console.WriteLine("quvveti daxil edin");

        double quvvet = double.Parse(Console.ReadLine());
        double netice = 1;
        for (int i = 0; i < quvvet; i++)
        {
            netice *= eded;
        }

        Console.WriteLine("netice:" +netice);

    }



}











//Sizdən riyazi əməliyyatları yerinə yetirən bir proqram təminatının hazırlanması istənilməkdədir. Proqram
//təminatı başladılığda istifadəçiyə aşağıdakı kimi bir menyu göstəriləcəkdir.
//1. Toplama
//2. Çıxma
//3. Vurma
//4. Bölmə
//5. Üst alma
//6. Çıxış
//Bu menyuya əsasən istifadəçi hər hansı bir əməlliyat seçimi edərək uyğun proqram birimi işlədəcəkdir.Bu
//proqram birimi isitifadəçidən seçdiyi bölməyə uyğun olaraq parametrələrin daxil ediməsini tələb
//edəcəkdir.Daxil edilən parametrə və seçilən menyu növünə uyğun olaraq riyazı əməlliyat edilərək alınan
//cavab hazırlanaraq istifadəçiyə göstərilməsi təmin edilməlidir.Proqram təminatı ilk seçimə uyğun
//məlumatları ekrandan göstərildikdən sonra ana menyuya geri dönüş edəbilməlidir. Əgər istifadəçi
//menyudan 6-ci bölməni seçərsə proqram təminatı sonlanacaqdır.
//Proqram təminatının hazırlanmasında aşağıdakı qeydlər diqqətə alınmalıdır
//➢ Proqramın təminatında əməliyyatlar və buna bənzər işlərin hazırlanmasında methodlardan
//istifadə edilməlidir
//➢ Proqram təminatında davamlığın təmin edilməsi üçün döngülərdən istifadə edilməlidir
//➢ Proqram təminatında seçimlərin ediləbilməsi üçün “switch case” yanaşmasında isitadə edilmelidir