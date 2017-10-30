using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace sch
{
    class Student
    {

        public string name { get; set; }
        public string surname { get; set; }
        public int grade { get; set; }
        public string gender { get; set; }


        private class CsvPersonMapping : CsvMapping<Student>
        {
            public CsvPersonMapping()
                : base()
            {
                MapProperty(0, x => x.name);
                MapProperty(1, x => x.surname);
                MapProperty(2, x => x.gender);
                MapProperty(3, x => x.grade);
            }
        }

        public  IOrderedEnumerable<CsvMappingResult<Student>> Parse(string path)
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            CsvPersonMapping csvMapper = new CsvPersonMapping();
            CsvParser<Student> csvParser = new CsvParser<Student>(csvParserOptions, csvMapper);

            var result = csvParser.ReadFromFile(@path, Encoding.UTF8).ToList();
            var query = result.OrderBy(p => p.Result.grade);

            return query;
        }


        public void print(IOrderedEnumerable<CsvMappingResult<Student>> query)
        {
            foreach (var score in query)
            {
                Console.WriteLine(score.Result);
            }
        }

        public void print(IEnumerable<CsvMappingResult<Student>> score)
        {
            foreach (var s in score)
                Console.WriteLine(s.Result);
        }

        public IEnumerable<CsvMappingResult<Student>> ListFiltering(IOrderedEnumerable<CsvMappingResult<Student>> query,string[] args)
        {
            if (args.Contains("K") == true || args.Contains("E") == true || args.Contains("e") || args.Contains("k"))
            {
                var score = query.Where(p => (p.Result.gender == args[0].ToUpper()));

                return score;
            }
            else
            {
                var score = query.Where(p => (p.Result.grade == Convert.ToInt32(args[0])));

                return score;
            }
        }

        public override string ToString()
        {
            return   grade.ToString() + "\t " + name.ToString() + "\t " + surname.ToString() + "\t " + gender.ToString();
        }

    }
}
