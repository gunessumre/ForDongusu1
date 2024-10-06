
//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int i;
for (i = 1; i <= 10; i++)
{
    Console.WriteLine("endime inanıyorum, ben bu yazılım işini hallederim!");
}

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
int j;
for (j = 1; j <= 20; j++)
{
    Console.WriteLine(j);
}

// 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
 int k;
 for (k = 2; k <= 20; k+=2)
 {
     Console.WriteLine(k);
 }
 
 //4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
 int m;
 int toplam = 0;
 /* ilk degeri sifir olan bir toplam degerine ihtiyacimiz var cunku toplam degiskeninin illk degeri
  olmadigi icin hata verecekti*/
 for (m = 50; m <= 150; m++)
 {
     toplam = toplam + i;
 }
 Console.WriteLine("Toplam: "+toplam);
 
 //5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
 //Tek sayilar
 int n;
 int toplam1=0;
 for (n =1 ; n <= 120; n += 2)
 {
     toplam1 = toplam1 + n;
 }
 Console.WriteLine("Toplam1: "+toplam1);
//cift sayilar
int n;
 int toplam2=0;
 for (n =2 ; n <= 120; n += 2)
 {
     toplam2 = toplam2 + n;
 }
 Console.WriteLine("Toplam2: "+toplam2);



