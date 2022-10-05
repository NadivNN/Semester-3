using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester3
{
    class Program
    {
        //deklrasi array int dengan ukuran 20
        private readonly int[] a = new int[20];

        //deklarasi variabel int untuk menyimpan banyaknya data yang disimpan pada array
        private int n;

        //fungsi / method untuk menerima masukan
        public void Read()
        {
            //menrima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada party 
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }

        }
      
        }
    }

}