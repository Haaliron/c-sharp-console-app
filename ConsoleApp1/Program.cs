namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kaç Adet Rastgele Sayı Üretileceğini Giriniz :");
        int sayiSayisi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");


        List<int> sayilar = new List<int>();
        Random rnd = new Random();


        for (int i = 0; i < sayiSayisi; i++) 
        {
            int sayi = rnd.Next(1, 30);
            
            sayilar.Add(sayi);
            
        }
        

        Dictionary<int, char> alfabeKarsilik = new Dictionary<int, char>()
            {
                { 1, 'a' },{ 2, 'b' },{ 3, 'c' },{ 4,'ç'},{ 5,'d'},{ 6,'e'},{ 7,'f'},{ 8,'g'}, { 9,'ğ'},{ 10,'h'},{ 11,'ı'},{ 12,'i'},
                { 13,'j'},{ 14,'k'},{ 15,'l'},{ 16,'m'},{ 17,'n'},{ 18,'o'}, { 19,'ö'},{ 20,'p'},{ 21,'r'},{ 22,'s'},{ 23,'ş'},
                { 24,'t'},{ 25,'u'},{ 26,'ü'},{ 27,'v'},{ 28,'y'},{ 29,'z'}
            };

        List<char> karakterler = new List<char>();

        foreach (int sayi in sayilar)
        {
            if (alfabeKarsilik.ContainsKey(sayi))
            {
                char karakter = alfabeKarsilik[sayi];
                karakterler.Add(karakter);
                
            }
        }

        Console.WriteLine(" ");
        Console.WriteLine("Gruplama Yapmak İçin 2 Adet Sayı Giriniz...");
        Console.WriteLine(" ");

        Console.WriteLine("Birinci Sayı :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");

        Console.WriteLine("İkinci Sayı:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");

        List<int> kume1 = new List<int>();
        List<int> kume2 = new List<int>();

        foreach (int num in sayilar)
        {

            int uzaklik1 = Math.Abs(num - sayi1);
            int uzaklik2 = Math.Abs(num - sayi2);

            if (uzaklik1 < uzaklik2)
                kume1.Add(num);
            else if (uzaklik2 < uzaklik1)
                kume2.Add(num);
            else
            {
                if (Math.Abs(num - sayi1) < Math.Abs(num - sayi2))
                    kume1.Add(num);
                else
                    kume2.Add(num);
            }
        }

        

        Console.WriteLine();
        Console.WriteLine("Kümedelerde Bulunan 3 Adet Karakteri Tahmin Ediniz (Örnek: k-f-t): ");
        Console.WriteLine("Birinci Karakter :");
        string tahminKume1 = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("İkinci Karakter :");
        string tahminKume2 = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Üçüncü Karakter :");
        string tahminKume3 = Console.ReadLine();
        Console.WriteLine();

        char aranacakHarf = Convert.ToChar(tahminKume1[0]);
        int sayac = 0;
        foreach (char harf in karakterler)
        {
            if (harf == aranacakHarf)
                sayac++;
        }

        char aranacakHarf2 = Convert.ToChar(tahminKume2[0]);
        int sayac2 = 0;
        foreach (char harf in karakterler)
        {
            if (harf == aranacakHarf2)
                sayac2++;
        }

        char aranacakHarf3 = Convert.ToChar(tahminKume3[0]);
        int sayac3 = 0;
        foreach (char harf in karakterler)
        {
            if (harf == aranacakHarf3)
                sayac3++;
        }

        Console.WriteLine("Aranan birinci harf dizide {0} defa geçiyor.", sayac);
        Console.WriteLine("Aranan ikinci harf dizide {0} defa geçiyor.", sayac2);
        Console.WriteLine("Aranan üçüncü harf dizide {0} defa geçiyor.", sayac3);
        Console.WriteLine();

        foreach (int sayi in sayilar)
        {
            if (alfabeKarsilik.ContainsKey(sayi))
            {
                char karakter = alfabeKarsilik[sayi];
                Console.Write(sayi + "-" + karakter + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Küme 1: " + string.Join(", ", kume1));
        Console.WriteLine();
        Console.WriteLine("Küme 2: " + string.Join(", ", kume2));

    }
}