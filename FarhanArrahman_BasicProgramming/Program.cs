using System;

namespace FarhanArrahman_BasicProgramming
{
    class Program
    {
        static Program program = new Program();

        string[] dataPegawai = new string[] { };

        static void Main(string[] args)
        {
            program.MainMenu();
        }

        void MainMenu() // Method Void
        {
            Console.WriteLine("-- Aplikasi Presensi --");
            Console.WriteLine("1. Daftar");
            Console.WriteLine("2. Lihat Data Pegawai");
            Console.WriteLine("3. Login");
            Console.WriteLine("9. Keluar");
            Console.Write("Masukkan Pilihan : ");
            int chosenNumber = program.NumberPicker();
            program.Processor(chosenNumber);
        }

        int NumberPicker() // Method Non-Void
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        void Processor(int chosenNumber) // Method Void
        {
            switch (chosenNumber) // Decision
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("-- Form. Pendaftaran --");
                    string[] data = program.Register();
                    dataPegawai = data;
                    Console.WriteLine("\nPendaftaran Berhasil!\n");
                    program.MainMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("-- Data Pegawai --");
                    program.DisplayPegawai();
                    Console.Write("\n");
                    program.MainMenu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("-- Login --");
                    bool isValid = program.Login();
                    if (isValid == true)
                    {
                        Console.WriteLine("\nBerhasil Login\n");
                    } else
                    {
                        Console.WriteLine("\nEmail/Password Salah!\n");
                    }
                    program.MainMenu();
                    break;
                case 9:
                    Console.WriteLine("\nSampai Jumpa!");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Pilihan tidak tersedia.\n");
                    program.MainMenu();
                    break;
            }
        }

        string[] Register() // Method Non-Void
        {
            string[] variables = new string[]
            {
                "Nama",
                "Tempat Lahir",
                "Tanggal Lahir (YYYY-MM-DD)",
                "Gender (L/P)",
                "Agama",
                "Alamat",
                "Email",
                "Nomor Handphone",
                "Foto (NamaFile.jpeg/jpg/png)"
            };
            string[] data = new string[variables.Length];
            foreach (var variable in variables)
            {
                Console.Write(variable + " : ");
                string userInput = Console.ReadLine();
                data[Array.IndexOf(variables, variable)] = userInput;
            }
            return data;
        }

        void DisplayPegawai() // Method Void
        {
            string[] variables = new string[]
            {
                "Nama",
                "Tempat Lahir",
                "Tanggal Lahir (YYYY-MM-DD)",
                "Gender (L/P)",
                "Agama",
                "Alamat",
                "Email",
                "Nomor Handphone",
                "Foto (NamaFile.jpeg/jpg/png)"
            };
            if(dataPegawai.Length == 0)
            {
                Console.WriteLine("Tidak Ada Pegawai!");
            } else
            {
                for (int i = 0; i < dataPegawai.Length; i++)
                {
                    Console.WriteLine(variables[i] + " : " + dataPegawai[i]);
                }
            }
        }

        bool Login() // Method Non-Void
        {
            Console.Write("Masukkan Email: ");
            string userEmail = Console.ReadLine();
            Console.Write("Masukkan Password: ");
            string userPw = Console.ReadLine();

            if (userEmail == "admin@gmail.com" && userPw == "admin")
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
