using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrogaman3353
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kar1 = new Karyawan(180601306, "Budi", 3300000);
            Karyawan kar2 = new Karyawan(180601307, "Surya", 4400000);

            Karyawan.Show(kar1, kar2);
            Karyawan.NaikGaji(kar1, kar2);
            Karyawan.Show(kar1, kar2);
        }
    }
}