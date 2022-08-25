internal class Program
{
    private static void Main(string[] args)
    {
        // String işlemleri

        string degisken = "Dersimiz Csharp, Hoşgeldiniz!";
        string degisken2 = "Csharp";
        // length karaketerleri sayar
        Console.WriteLine(degisken.Length);
        // tolower, toupper
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        // Concat
        Console.WriteLine(string.Concat("Merhaba ", degisken));

        // Compare, birinci değişken ikinci değişkene eşit ise 0, ilk değişkenin karakter sayısı birden büyük ise 1, daha küçük ise -1 döndürür. 
        // comparato 2 değişkeni belirttikten sonra 3. prametre true olursa küçük büyük harf duyarlı, false olursa duyarsız olur.  
        // string degisken = "Dersimiz Csharp, Hoşgeldiniz!";
        // string degisken2 = "dersimiz Csharp, Hoşgeldiniz!";
        Console.WriteLine(degisken.CompareTo(degisken2));
        Console.WriteLine(string.Compare(degisken,degisken2,true));  // Sonuç 0
        Console.WriteLine(string.Compare(degisken,degisken2,false)); // sonuc 1

        // context değiskenin içinde bir texti ararken kulalnılır. 
        // string degisken = "Dersimiz Csharp, Hoşgeldiniz!";
        // string degisken2 = "Csharp";
        Console.WriteLine(degisken.Contains(degisken2)); // Sonuç True
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
        Console.WriteLine(degisken.StartsWith("Merhaba"));

        // indexof Değişkenin içinde istenen kelimeyi arayacak ilk bulduğu karekterin sırasını yazacak. Bulamazsa da -1 
        Console.WriteLine(degisken.IndexOf("Csharp")); // Sonuc 9
        Console.WriteLine(degisken.IndexOf("alis")); // Sonuc -1

        // insert belli bir 
        Console.WriteLine(degisken.Insert(0,"Merhaba"));
        //LAst index of sondan kaçıncı harfın yerini döner. 
        Console.WriteLine(degisken.LastIndexOf("i"));
        
        //padleft degişkenin boyutunu istediğiniz karakter sayısına geitrmek için boşluk veya istenilen karakteri ekler. 
        Console.WriteLine(degisken + degisken2.PadLeft(30));
        //Dersimiz Csharp, Hoşgeldiniz!                        Csharp
        Console.WriteLine(degisken2.PadRight(20)+degisken);
        Console.WriteLine(degisken2.PadRight(20,'*')+degisken);
        //  remove
        Console.WriteLine(degisken.Remove(10,5));
        
        // Replace
        Console.WriteLine(degisken.Replace("Csharp","C#"));

        //Split istenen karaktere göre değikeni böler ve bir diziye atar
        Console.WriteLine(degisken.Split(' ')[2]); // Sonuç Hoşgeldiniz!
        Console.WriteLine(degisken.Split(' ')[0]); // Sonuç Dersimiz 

        // Substring
        Console.WriteLine(degisken.Substring(4,6)); // 4.indexten başla sonraki  6 karakteri getir. 



    }
}