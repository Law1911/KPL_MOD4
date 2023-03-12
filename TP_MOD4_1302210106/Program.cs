// See https://aka.ms/new-console-template for more information
namespace TP_MOD4_KPL
{
    class Mainprogram
    {
        public static void Main(string[] args)
        {
            KodePos table_kode_pos = new KodePos();
            Console.Write("Masukan Kota yang ingin dilihat kode pos : ");
            String kota = Console.ReadLine();

            table_kode_pos.getkodepos(kota);

            Console.WriteLine("");

            Console.WriteLine("Door Status");

            DoorMachine door = new DoorMachine();

            door.key();
        }
    }
    class KodePos
    {
        Dictionary<string, int> dic_Kode_daerah = new Dictionary<string, int>(){
            {"Batununggal", 40266},
            {"Kujangsari", 40287},
            {"Mengger", 40267},
            {"Wates", 40256},
            {"Cijaura", 40287},
            {"Jatisari", 40286},
            {"Margasari", 40286},
            {"Sekejati", 40286},
            {"Kebonwaru", 40272},
            {"Maleer", 40274},
            {"Samoja", 40273},
        };

        public void getkodepos(string kode)
        {
            if (dic_Kode_daerah.ContainsKey(kode))
            {
                Console.WriteLine(kode + " : " + dic_Kode_daerah[kode]);
            }
            else
            {
                Console.WriteLine(kode + " Kode tidak terdaftar");
            }
        }
    }
    class DoorMachine
    {
        enum State { Terkunci, Terbuka, Exit };

        public void key()
        {
            State state = State.Terkunci;

            String[] door_status = { "Terkunci", "Terbuka", "Keluar" };
            do
            {
                Console.WriteLine("Pintu " + door_status[(int)state]);
                Console.Write("Keyword : ");
                String command = Console.ReadLine();
                switch (state)
                {
                    case State.Terkunci:
                        if (command == "Buka Pintu")
                        {
                            state = State.Terbuka;
                        }
                        break;
                    case State.Terbuka:

                        if (command == "Kunci Pintu")
                        {
                            state = State.Terkunci;
                        }
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }

}
    
