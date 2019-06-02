using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public class ColumnAttribute:Attribute
    {
        public string name;

        public bool notNull;

        public DbType dbType;

        public ColumnAttribute(string name,bool notNull,DbType dbType)
        {
            this.name = name;
            this.notNull = notNull;
            this.dbType = dbType;
        }
    }

    public class TableAttribute : Attribute
    {
        public string name;

        public TableAttribute(string name)
        {
            this.name = name;
        }
    }
}
