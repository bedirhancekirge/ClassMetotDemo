using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusterıManager
    {
        public void Sıl(Musterı musterı)
        {
            Console.WriteLine("Bu Müşteriyi Silimek İstiyor musunuz? : " + Environment.NewLine + "Adı Soyadı : " + musterı.Adı +" "  + musterı.Soyadı + Environment.NewLine + "TC Kimlik NUmarası : " + musterı.KımlıkNumarası +  Environment.NewLine + "Doğum Tarhi : " + musterı.DagumTarıhı + Environment.NewLine  + "Telefon Numarası : " + musterı.TelefonNumara);

            
        }
         public void MusteriEkle(Musterı musterı)
        {
            Console.WriteLine("Bu Müşteri Sisteme Eklendi : " + Environment.NewLine + "Adı Soyadı : " + musterı.Adı + " " + musterı.Soyadı + Environment.NewLine + "TC Kimlik NUmarası : " + musterı.KımlıkNumarası + Environment.NewLine + "Doğum Tarhi : " + musterı.DagumTarıhı + Environment.NewLine + "Telefon Numarası : " + musterı.TelefonNumara);
        }
    }
}
