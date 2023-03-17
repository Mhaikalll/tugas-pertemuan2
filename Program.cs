            Console.WriteLine("\nAplikasi Kalkulator Sederhana \n");
            Console.WriteLine("1. Penjumlahan \n2. Pengurangan \n3. Perkalian \n4. Pembagian");
            Console.WriteLine("_______________________");
            Console.Write("Pilih 1/2/3/4 : ");
            char pilih = char.Parse(Console.ReadLine());
            Console.WriteLine("_______________________");

            // Input Angka
            Console.Write("Input nilai a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input nilai b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_______________________");


            switch (pilih)
            {
                case '1':
                    Console.WriteLine("Hasil");
                    Console.WriteLine(a + " + " + b + " = " + penjumlahan(a, b));
                    break;
                case '2':
                    Console.WriteLine("Hasil");
                    Console.WriteLine(a + " - " + b + " = " + pengurangan(a, b));
                    break;
                case '3':
                    Console.WriteLine("Hasil");
                    Console.WriteLine(a + " * " + b + " = " + perkalian(a, b));
                    break;
                case '4':
                    Console.WriteLine("Hasil");
                    Console.WriteLine(a + " / " + b + " = " + pembagian(a, b));
                    break;
                default:
                    Console.WriteLine("Ra enek mas");
                    break;
            }

            Console.WriteLine("\n");
        

        static int penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }