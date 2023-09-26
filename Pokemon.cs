using QueryBuilderStarter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
    // Pokemon Class Model
    public class Pokemon : IClassModel
    {
        public int Id { get; set; }
        public int DexNumber { get; set; }
        public string Name { get; set; }
        public string Form { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }


        public static Pokemon FromFile(string line)
        {
            string[] values = line.Split(',');
            Pokemon reader = new Pokemon

            {
               // Id = int.Parse(values[0]),
                DexNumber = int.Parse(values[0]),
                Name = values[1],
                Form = values[2],
                Type1 = values[3],
                Type2 = values[4],
                Total = int.Parse(values[5]),
                HP = int.Parse(values[6]),
                Attack = int.Parse(values[7]),
                Defense = int.Parse(values[8]),
                SpecialAttack = int.Parse(values[9]),
                SpecialDefense = int.Parse(values[10]),
                Speed = int.Parse(values[11]),
                Generation = int.Parse(values[12])
            };

            return reader;
        }
    }
}