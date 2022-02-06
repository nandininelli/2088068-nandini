using System;

namespace Singleton_HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConn db = DBConn.MyObject();
            db.PrintOnConsole();
        }
    }

    public sealed class DBConn
    {   
        private DBConn()
        {

        }
        public  static DBConn instance=null;

        public static DBConn MyObject()
        {
            if(instance==null)
            {
                return new DBConn();
            }
            return instance;
        }

        public void PrintOnConsole()
        {
            Console.WriteLine("This Is Implementation Of SingleTon Class");
        }



    }
}
