using System;

namespace sch
{
    class Program
    {
        static Boolean arg_controller(string[] args)
        {
            string[] valid_args = new String[]{ "1", "2", "3", "4", "E", "K", "e", "k" };

            string arg = args[0];

            return Array.Exists(valid_args,element => element == arg);
        }

        static void Main(string[] args)
        {
            Student student = new Student();

            var query = student.Parse("../../okul.csv");

            if (args.Length == 0)
            {
                student.print(query);
            }

            else if (args.Length > 1)
            {
                Console.WriteLine("Hatali Arguman sayisi");
            }
            else
            {
                if (arg_controller(args))
                {

                    student.print(student.ListFiltering(query, args));
                }

                else Console.WriteLine("Hatalı arguman girişi");
            }

        }

    }
}
