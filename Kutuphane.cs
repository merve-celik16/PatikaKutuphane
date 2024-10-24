using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKutuphane
{
    public class Kutuphane
    {
        public string Ad;
        public string YazarAdi;
        public string YazarSoyadi;
        public int SayfaSayisi;
        public string Yayinevi;
        public DateTime KayitTarihi;

        public Kutuphane() //Parametresiz Constructor
        {
            KayitTarihi = DateTime.Now;
        }
        //Parametreli Constructor
        public Kutuphane(string _ad, string _yazarAdi, string _yazarSoyadi, int _sayfaSayisi, string _yayinevi)
        {
            Ad = _ad;
            YazarAdi = _yazarAdi;
            YazarSoyadi = _yazarSoyadi;
            SayfaSayisi = _sayfaSayisi;
            Yayinevi = _yayinevi;
            KayitTarihi = DateTime.Now;
        }
        
        public void Bilgi()
        {
            Console.WriteLine($"Kitap Adı: {Ad}, Yazar: {YazarAdi} {YazarSoyadi}, Sayfa Sayısı: {SayfaSayisi}, Yayinevi: {Yayinevi}, Kayıt Tarihi: {KayitTarihi}");
        }
    }
}
