using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PratikPolymorphism
{
    //base class
    public class BaseGeometrikSekil
    {
        //türetilmiş sınıfların ulaşması için protected kullandım
        protected int _genislik { get; set; }
        protected int _uzunluk { get; set; }
        public BaseGeometrikSekil(int genislik, int uzunluk)
        {
            _genislik = genislik;
            _uzunluk = uzunluk;
        }
        //override yapılacağı için virtual kullanıldı
        public virtual int AlanHesapla()
        {
            int alan = _genislik * _uzunluk;
            return alan;

        }
    }
    //kare sınıfı ve altında constructor bulunuyor
    public class Kare : BaseGeometrikSekil
    {
        public Kare(int kenarUzunluk,int kenarUzunluk2) : base(kenarUzunluk, kenarUzunluk)
        {
        }
    }
    //dikdörtgen sınıfı ve altında constructor bulunuyor
    public class Dikdörtgen : BaseGeometrikSekil
    {
        public Dikdörtgen(int uzunKenar, int kisaKenar) : base(uzunKenar, kisaKenar)
        {
        }
    }
    //dikucgen sınıfı ve altında constructor bulunuyor
    public class DikUcgen : BaseGeometrikSekil
    {
        public DikUcgen(int kenarUzunluk, int kenarUzunluk2) : base(kenarUzunluk, kenarUzunluk2)
        {
            
        }
        //alanhesapla metodu override edilerek alan hesaplama yöntemi değiştirildi
        public override int AlanHesapla()
        {
            int alan = (_genislik * _uzunluk) / 2;
            return alan;
        }
    }
}
