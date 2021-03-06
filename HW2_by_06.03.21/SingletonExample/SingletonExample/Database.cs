using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Text;

namespace SingletonExample
{
    class Database
    {
        private static Database instance;
        private static object threadLock = new object();
        private Database()
        {
            Console.WriteLine("Подключено к БД");
        }
        public static Database getInstance()
        {
            if (Database.instance == null)
            {
                if (instance == null)
                {
                    lock (threadLock)
                    {
                        if (instance == null)
                            instance = new Database();
                    }
                }
            }
            return instance;
        }
        public void query(string sql)
        {
            Console.WriteLine("Комманда: " + sql);
        }
    }
}
