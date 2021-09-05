using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hade_database.Data
{
    public class SqlConnectionConfiguration
    {
        public SqlConnectionConfiguration(string value) => Value = value;
        public string Value { get; }
    }
}