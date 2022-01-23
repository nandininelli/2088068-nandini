using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace WindowsService1
{
    public class Work
    {
        public static void WriteErrorLog(Exception ex)
        {
            StreamWriter sw = null;
            sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + ".txt", true);
            sw.WriteLine(ex.Source.ToString() + ";" + ex.Message.ToString() + DateTime.Now.ToString());
            sw.Close();
        }



        public static void WriteErrorLog(string Message)
        {
            StreamWriter sw = null;
            sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + ".txt", true);
            sw.WriteLine(Message + DateTime.Now.ToString() + ":");
            sw.Close();
        }



    }
}