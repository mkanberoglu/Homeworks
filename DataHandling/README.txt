Arakadaşlar merhaba, bu haftaki ödevinizi açıklıyorum.
Gördüğünüz üzere BanaVeriGetir adında bir dll dosyamız mevcud.
bu dll size bir car_data.txt dosyasının içersinde bulunan verileri bir liste halinde döndürecektir.
bu verileri kendiniz incelmenizi istiyorum.

Sizden ödev olarak istediğim şeyler aşağıdaki gibidir;
Araba satın almış(alan) kadınların yaş ortalaması,
Araba satın almış(alan) erkeklerin yaş ortalaması,
Yıllık geliri en yüksek olan kadının User_ID'sini yaşını ve ne kadar yıllık geliri olduğunu,
Yıllık geliri en yüksek olan erkeğin User_ID'sini yaşını ve ne kadar yıllık geliri olduğunu.
tamam bu kadar yeter :) işte bunları bana verecek bir sınıf yazmanızı istiyorum. Sınıftan nesne ürettiğimde bana bu bilgilerin verilmesini istiyorum.
bu dll'i bende yazdım(farklı bir veri ile ve farklı bir kütüphane kullanarak) diyenlere kantinden kahvesi benden. 
bu verilerden anlamla bir sonuç çıkartana(kod ile tabiki bakıp hmm böyleymiş değil) Antep'te istediği yerden kahvesi benden :)


--------------------------------------------------------------------
//dll'in kullanımı şu şekildedir.
using TxtDataRead;
namespace Program
{
    class CarRace
    {
        public static void Main(string[] args)  
        {
            BanaVeriGetir.Getir("D:\\archive\\car_data.txt");

        }
    }

}

∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞∞
   <ItemGroup>
     <Reference Include="TxtDataRead">
       <HintPath>BanaVeriGetir.dll</HintPath>
     </Reference>
    </ItemGroup>

© created by Ramazan