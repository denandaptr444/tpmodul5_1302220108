using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpmodul5_1302220108;

namespace tpmodul5_1302220108
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T userName)
        {
            Console.WriteLine($"Halo user {userName}");
        }
    }
}

class DataGeneric<T>
{
    T Data { get; set; }
    public DataGeneric(T data)
    {
        Data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}
class Program
{
    static void Main(string[] args)
    {

        HaloGeneric halo = new HaloGeneric();


        string nickname = "Denanda";
        halo.SapaUser(nickname);
        DataGeneric<string> dataString = new DataGeneric<string>("Y");
        dataString.PrintData();
        DataGeneric<string> dataNim = new DataGeneric<string>("1302220108");
        dataNim.PrintData();
        Console.ReadLine();
    }
}