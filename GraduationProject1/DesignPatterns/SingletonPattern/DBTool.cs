using GraduationProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject1.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        DBTool() { }

        static AirportDBEntities _dbInstance;

        public static AirportDBEntities DBInstance
        {
            get
            {
                if (_dbInstance == null)
                {
                    _dbInstance = new AirportDBEntities();
                }
                return _dbInstance;
            }
        }
    }
}
