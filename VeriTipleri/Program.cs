using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "Mehmetpekince"; /* Değişken oluştururken değiken ismi sayıyla başlamaz ve karakterer arası boşluk olmaz olursa hata alırsın.
                                                * Türkçe karakter kullanılmamalıdır ç,ö,ü,ğ gibi vb. */
            byte birinci = 255;
            // byte ikinci = 256;  256 sayısını byte fonksiyonunun içine koyduğumuzda hata vecektir. Because : byte içine en fazla 0-255 sayısına kadar depolayabilir.

            /* -------------------------------------------------------------- BYTE VERİ TİPİ --------------------------------------------------------------------------------- */
            byte maxdeger = byte.MaxValue; // MaxValue yazdığım zn bana byte değişkeninin alabileceği en büyük değeri söyleyecektir.
            byte mindeger = byte.MinValue; // MinValue yazdığımdaysa bana en küçük değerini vercektir.


            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            Console.WriteLine(birinci);
            Console.WriteLine(sayi);

            /*  ---------------------------------------------------------------SHORT VERİ TİPİ------------------------------------------------------------------------------ */


            // SHORT veri tipi -32768 to 32768 sayısına kadar içinde depoluyor 

            short birinciDeğisken = -1500; // sort veri tipi içinde eksili sayıları tutabilir byte da tutlmaz.
            short maxshortDeğisken = short.MaxValue; // aynı byte daki gibi büyük değerini görmüş olacağız.
            short minShort = short.MinValue; // aynı byte daki gibi en küşük değeri görmüş olcağız.

            Console.WriteLine(birinciDeğisken);
            Console.WriteLine(maxshortDeğisken);
            Console.WriteLine(minShort);


            /* ----------------------------------------------------------------- İNT VERİ TİPİ ---------------------------------------------------------------------------------*/

            int birinciİnt = 150;   // İnt veri tipinde -2.147.483.648 to 2.147.483.648 değerlerini alabilir byte a ve shorta göre kat ve kat çoktur.
            int maximDeger = int.MaxValue; // diğer veri tipleriyle aynı mantıkta çalışır diğerleri gibi buda en büyük değeri yazdırır yani 2.147.483.648 değerini yazdırcaktır.
            int minimDeger = int.MinValue; // buda int değerinin en küçük değerini yazdırcaktır yani -2.147.483.648 değerini vercektir bize.

            Console.WriteLine(birinciİnt);
            Console.WriteLine(maximDeger);
            Console.WriteLine(minimDeger);

            /*------------------------------------------------------------------LONG VERİ TİPİ----------------------------------------------------------------------------------*/

            // 8 byte yer kaplamaktadır rambellekte.

            long DegiskenLong = 1453;  // long veri tipi -9.223.372.036.854.775.808 to 9.223.372.036.854.775.808 arasında değer depolayabilmektedir.
            long maxDegerLong = long.MaxValue;
            long minDegerLong = long.MinValue;

            Console.WriteLine(DegiskenLong);  // burada alcağımız çıktı Degiskenlong olacaktır.
            Console.WriteLine(maxDegerLong);  // burada alcağımız çıktı maxDegerLong olcaktır.
            Console.WriteLine(minDegerLong);  // burada alacağımız çıktı minDegerLong olacaktır.



            /*--------------------------------------------------------------------FLOAT VERİ TİPİ ------------------------------------------------------------------------------*/


            // FLOAT VERİ TİPİ 4 BYTE YER KAPLAMATADIR RAMBELLEKTE.
            // Float değerinin içine ondalıklı sayılar depolanır.


            float DegerOndalik = 45.7f;  /* ondalık sayımızı atadıktan sonra yanına f yazmalıyız.
                                          * nedeni ise yazdığımız değerin ondalık değer yani float olduğunu anlaması içinyazıyoruz
                                          * eğer yamazsak bize hata vercektir nedeni ise  onu double sanmasıdır.
                                          * en fazla 7 basamak sayı tutabilir içinde*/
            Console.WriteLine(DegerOndalik);


            /*---------------------------------------------------------------------DOUBLE VERİ TİPİ -----------------------------------------------------------------------------*/


            // 8 BYTE yer kaplar Rambellekte.
            // double veri tipi içinde ondalıklı sayıları tutar floatdan farkı ise 15 basamak değere kadar içinde değerleri tutmasıdır.

            double DegerDouble = 12.5673854;  // gördüğünüz gibi 7 den fazla değeri içinde tutabiliyor

            Console.WriteLine(DegerDouble);


            /*---------------------------------------------------------------------CHAR VERİ TİPİ -------------------------------------------------------------------------------*/

            // Sadece karakterlei içinde tutmak için kullanılan veri tipine "Char" veri tipi denir
            // tek tırnak içine tek değer olarak yazılır.

            char DegerChar = 'M'; //gördüğünüz gibi tek tırnak içinde tek değer yazdık.
            char DegerChar2 = 'Z'; // Her zaman tek tırnak kullanmalıyız char veri tipinde çift tırnak kullanırsak hata alırız


            Console.WriteLine(DegerChar);
            Console.WriteLine(DegerChar2);

            /*---------------------------------------------------------------------STRİNG VERİ TİPİ-----------------------------------------------------------------------------*/

            // Stiring girilen 8 byte+girilen karakter kadar rambellekte yer kaplar

            string DegerStr = "Mehmet"; // tek tırnakla yazılmaz yazılırsa hata alırsınız çift tırnakla yazılması gerekir.
            string DegerStr2 = "Pekince";

            Console.WriteLine(DegerStr + DegerStr2); // örnektede gördüğünüz gibi araya "+" işareti koyduğumuz zaman bize iki sonucu bireştirip yazcaktır.


            /*---------------------------------------------------------------------- BOOL VERİ TİPİ -----------------------------------------------------------------------------*/

            // Bool veri tipinde sadece iki tane veri saklanır bunlar "True ve False" dır.

            bool Bak = true;  // doğru demektir
            bool Bak2 = false; // yanlış demektir 

            // peki nasıl kulanılır.

            bool cıktı = 50 < 25;   // 50 küçüktür 25 demş olduk bunun doğru veya yanlış olduğunu bize çıktısını vercektir
            Console.WriteLine(cıktı);  // burada bana false çıktısını vercek çünkü 50 25 den küçük değildir.


            /*----------------------------------------------------------------------- OBJECT VERİ TİBİ -----------------------------------------------------------------------------*/

            // Tüm veri tiplerinin babasıdır içinde tüm veri tipleri saklanabilir 
            // örneğin 

            object Degerbaba = true;
            object Degerbaba2 = "salih";
            object Degerbaba3 = 350;
            object Degerbaba4 = 3.15;


                    Console.ReadLine();


            // gördüğünüz gibi iine tüm değişkenleri alabilr 

            /*------------------------------------------------------------------------- VERİ TİPLERİ BUKADAR :) -----------------------------------------------------------------------*/
            // eğer kendi bilgisayarınızda çalıştırıp denemek isterseniz her vri tipini tek tek denemenizi tavsi ediyorum karışıklık olmasın çıktılarda
        }

    }
}
