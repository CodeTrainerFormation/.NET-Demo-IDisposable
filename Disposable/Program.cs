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

            //-----1st solution-----
            //LogFileWriter log = new LogFileWriter();

            //try
            //{
            //    //you can use log object here
            //}
            //finally
            //{
            //    //free managed and unmanaged resources
            //    log.Dispose();
            //}

            //-----2nd solution-----
            //using (LogFileWriter log = new LogFileWriter())
            //{
            //    //you can use log object here
            //
            //}//implicit call Dispose() method

            Console.ReadLine();
        }
    }


}
