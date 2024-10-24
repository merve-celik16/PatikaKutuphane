namespace PatikaKutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kitap1 = new Kutuphane();
            kitap1.Ad = "Tutunamayanlar";
            kitap1.YazarAdi = "Oğuz";
            kitap1.YazarSoyadi = "Atay";
            kitap1.SayfaSayisi = 724;
            kitap1.Yayinevi = "İletişim Yayınları";
            kitap1.Bilgi();

            Console.WriteLine();

            Kutuphane kitap2 = new Kutuphane("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
            kitap2.Bilgi();


            //Class: Kitap adında bir sınıf oluşturduk.
            //Bu sınıf, bir kitabın tüm özelliklerini (ad, yazar, sayfa sayısı vb.) içinde barındıran bir taslaktır.
            //Property : Ad, YazarAdi, YazarSoyadi, SayfaSayisi, Yayinevi ve KayitTarihi gibi her bir özellik için bir property tanımladık.
            //Bu property sayesinde bir kitabın özelliklerine dışarıdan erişip değer atayabiliriz.
            //Constructor : Bir nesne oluşturulduğunda otomatik olarak çalışan metotlardır.
            //Sınıfın özelliklerine ilk değerleri atamak için kullanılır. Bu örnekte iki adet constructor tanımladık.
            //1.Parametreli:Kitabın tüm bilgilerini parametre olarak alır ve bu bilgileri nesnenin ilgili özelliklerine atar.
            //2.Parametresiz:Hiçbir parametre almaz ve sadece kayıt tarihini o anki zamana eşitler.
            //Bu, örneğin kitap bilgilerini çekip daha sonra buraya atamak gibi durumlarda kullanışlı olabilir.
            //New : Kutuphane kitap1 = new Kutuphane() burada olduğu gibi yeni bir nesne oluşturur.



        }
    }
}
