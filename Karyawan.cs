using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrogaman3353
{
    class Karyawan
    {
        int NIK { get; set; }
        String Nama { get; set; }
        int GajiBulanan { get; set; }

        public Karyawan(int NIK, string Nama, int GajiBulanan)
        {
            if(GajiBulanan < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = GajiBulanan;
            }

            this.NIK = NIK;
            this.Nama = Nama;
        }

        public static void NaikGaji(Karyawan obj1, Karyawan obj2)
        {
            Console.WriteLine("");
            Console.WriteLine("Alhamdulillahnaik gaji 10%");
            Console.WriteLine("");
            obj1.GajiBulanan += obj1.GajiBulanan * 10 / 100;
            obj2.GajiBulanan += obj2.GajiBulanan * 10 / 100;

        }
        public static void Show(Karyawan obj1, Karyawan obj2)
        {
            Console.WriteLine("No NIK/Nama\t\tGajiBulanan");
            Console.WriteLine("1 {0}{1}\t{2}", obj1.NIK, obj1.Nama, obj1.GajiBulanan);
            Console.WriteLine("2 {0}{1}\t{2}", obj2.NIK, obj2.Nama, obj2.GajiBulanan);

        }
    }
}