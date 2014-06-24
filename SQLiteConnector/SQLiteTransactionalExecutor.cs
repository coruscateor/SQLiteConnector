using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using CoreComponents.Data;

namespace SQLiteConnector
{
    
    public class SQLiteTransactionalExecutor : TransactionalExecutor<SQLiteConnection, SQLiteCommand, SQLiteParameter>
    {

        public SQLiteTransactionalExecutor()
        {
        }

    }

}
