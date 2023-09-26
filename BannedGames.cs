using QueryBuilderStarter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
    // Banned Game Class with properties
    internal class BannedGame : IClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Series { get; set; }

        public string Country { get; set; }

        public string Details { get; set; }

        private static int idinc = 1;

        // Banned Game constructor
        public static BannedGame FromFile(string line)
        {
            string[] values = line.Split(',');
            BannedGame reader = new BannedGame
            {
                Id = idinc++,
                Title = values[0],
                Series = values[1],
                Country = values[2],
                Details = values[3]
            };

            idinc += 1;
            return reader;
        }
    }
}