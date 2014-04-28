using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using CoreComponents.Data;

namespace SQLiteConnector
{

    public class SQLiteConnectionAndCommandManager : ConnectionAndCommandManager<SQLiteConnection, SQLiteCommand, SQLiteParameter, SQLiteTransaction>
    {

        public SQLiteConnectionAndCommandManager()
        {
        }

    }

}
