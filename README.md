# Pratik - Patika Kütüphane
Patika Kütüphanesi için bir kitap kayıt uygulaması oluşturmak istiyoruz. Bu nedenle bu aşamada kitap nesneleri oluşturmamız gerekiyor.

Ad, Yazar Adı, Yazar Soyadı, Sayfa Sayısı, Yayınevi, Kayit Tarihi bilgileri ile kitaplar kaydetmek istiyoruz.

Örnek olarak

Ayşe Kulin'in 398 sayfalık, Remzi Kitabevi yayınevinden çıkan Adı Aylin kitabını oluşturunuz.

* 2 Adet constructor alternatifi olsun.

* Bir tanesi default constructor tarzında parmetre almadan çalışan bir metot.

* Diğeri Kitap adı, Yazar Adı, Sayfa Sayısı, Yayınevi  bilgilerini alıp bu değerleri nesne üretim aşamasında atayan bir metot.

* KayıtTarihi nesne oluşturulunca otomatik olarak o an olarak atansın. (Her iki constructor için de geçerli)

Kodlarınızın altına birer yorum satırıyla örnek üzerinden Class , Property , New , Constructor kavramlarını açıklayınız.


## Kod Açıklaması :

 * Class: Kitap adında bir sınıf oluşturduk.
   Bu sınıf, bir kitabın tüm özelliklerini (ad, yazar, sayfa sayısı vb.) içinde barındıran bir taslaktır.
 * Property : Ad, YazarAdi, YazarSoyadi, SayfaSayisi, Yayinevi ve KayitTarihi gibi her bir özellik için bir property tanımladık.
   Bu property sayesinde bir kitabın özelliklerine dışarıdan erişip değer atayabiliriz.
 * Constructor : Bir nesne oluşturulduğunda otomatik olarak çalışan metotlardır.
 * Sınıfın özelliklerine ilk değerleri atamak için kullanılır. Bu örnekte iki adet constructor tanımladık.
   1.Parametreli:Kitabın tüm bilgilerini parametre olarak alır ve bu bilgileri nesnenin ilgili özelliklerine atar.
   2.Parametresiz:Hiçbir parametre almaz ve sadece kayıt tarihini o anki zamana eşitler.
   Bu, örneğin kitap bilgilerini çekip daha sonra buraya atamak gibi durumlarda kullanışlı olabilir.
 * New : Kutuphane kitap1 = new Kutuphane() burada olduğu gibi yeni bir nesne oluşturur.
