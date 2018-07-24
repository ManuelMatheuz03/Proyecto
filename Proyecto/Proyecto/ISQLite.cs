using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proyecto
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
