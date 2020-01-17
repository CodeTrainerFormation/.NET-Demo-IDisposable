using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable
{
    class Program
    {
        static void Main(string[] args)
        {
            LogFileWriter log = new LogFileWriter();

            //-----1ere solution-----
            //LogFileWriter log = new LogFileWriter();

            //try
            //{
            //    //utiliser l'objet log
            //}
            //finally
            //{
            //    //liberation des ressources managées
            //    //et non managées
            //    log.Dispose();
            //}

            //-----2eme solution-----
            //using (LogFileWriter log = new LogFileWriter())
            //{
            //    //utiliser l'objet log

            //}//appel implicite à Dispose()

            Console.ReadLine();
        }
    }


}
