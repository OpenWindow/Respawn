using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respawn.Graph
{
    public class TemporalTable
    {
        public TemporalTable(string schema, string name, string historyTableName)
        {
            Schema = schema;
            Name = name;
            HistoryTableName = historyTableName;
        }

        public string Schema { get; }
        public string Name { get; }
        public string HistoryTableName { get; }
    }
}
