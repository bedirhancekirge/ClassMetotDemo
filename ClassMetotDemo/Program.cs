using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musterı musterı1 = new Musterı();
            musterı1.Adı = "Mücait";
            musterı1.Soyadı = "Adıgüzel";
            musterı1.DagumTarıhı = "05.08.1985";
            musterı1.KımlıkNumarası = "11111111111";
            musterı1.TelefonNumara = "0536845****";

            Musterı musterı2 = new Musterı();
            musterı2.Adı = "Arda";
            musterı2.Soyadı = "Bozlak";
            musterı2.DagumTarıhı = "05.08.2000";
            musterı2.KımlıkNumarası = "22222222222";
            musterı2.TelefonNumara = "0544865****";

            Musterı musterı3 = new Musterı();
            musterı3.Adı = "Meltem";
            musterı3.Soyadı = "Bozlak";
            musterı3.DagumTarıhı = "15.04.1998";
            musterı3.KımlıkNumarası = "33333333333";
            musterı3.TelefonNumara = "0578963****";

            Musterı musterı4 = new Musterı();
            musterı4.Adı = "Tuğba";
            musterı4.Soyadı = "Çekirge";
            musterı4.DagumTarıhı = "18.01.1987";
            musterı4.KımlıkNumarası = "88888888888";
            musterı4.TelefonNumara = "0504525****";

            Musterı musterı5 = new Musterı();
            musterı5.Adı = "Bedirhan";
            musterı5.Soyadı = "Çekirge";
            musterı5.DagumTarıhı = "11.12.1998";
            musterı5.KımlıkNumarası = "55555555555";
            musterı5.TelefonNumara = "0543682****";

            Musterı[] musterıler = new Musterı[] { musterı1, musterı2 };

            //foreach (Musterı musterı in musterıler){ }

            MusterıManager musterıManager = new MusterıManager();
            musterıManager.Sıl(musterı5);


            Console.WriteLine("--------------------------------------------------");


            musterıManager.MusteriEkle(musterı3);

        }
    }
}
