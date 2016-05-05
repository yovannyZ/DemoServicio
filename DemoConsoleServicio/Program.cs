using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoConsoleServicio.FootballServices;

namespace DemoConsoleServicio
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoSoapTypeClient proxy = new InfoSoapTypeClient("InfoSoap");
            Console.WriteLine("EQUIPOS");
            Console.WriteLine("========");

            tTeamInfo[] equipos = proxy.Teams();

           foreach(var item in equipos){
               Console.WriteLine(item.sName);
           }

           Console.ReadLine();


        }
    }
}
