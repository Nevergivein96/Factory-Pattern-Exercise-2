using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "mongo" : return new Mongo_Database();
                case "sql": return new SQL_Database();
                case "list": return new ListDataAccess();
                default: return new ListDataAccess();
            }
        }
    }
}
