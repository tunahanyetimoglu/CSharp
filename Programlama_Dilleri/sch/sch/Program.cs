using System;
using System.IO;
using System.Text.RegularExpressions;

namespace sch
{
    class Program
    {
        public static Boolean pathController(string path)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@path, FileMode.Open);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: Dosya bulunamadı!" );
                return false;
            }
            finally
            {
                if(fs != null)
                    fs.Close();
            }
        }
        static Boolean arg_controller(string[] args)
        {
            string[] valid_args = new String[]{ "1", "2", "3", "4", "E", "K", "e", "k" };

            string arg = args[0];

            return Array.Exists(valid_args,element => element == arg);
        }
        static void Main(string[] args)
        {
            Student student = new Student();

            string path = "../../okul.csv";

            if (pathController(path))
            {
                var query = student.Parse(path);

                if (Student.csvUniqueName(query))
                {

                    if (args.Length == 0)
                        student.print(query);

                    else if (args.Length > 1)
                    {
                        Console.WriteLine("Hatali Arguman sayisi.");
                    }
                    else if (arg_controller(args))
                    {
                        student.print(student.ListFiltering(query, args));
                    }
                    else if (Regex.IsMatch(args[0], @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Hatalı arguman girisi : {0}", args[0]);
                    }
                    else
                        Console.WriteLine("devre numarası 1 - 4 arasında olmalıdır");
                }
                else
                {
                    System.Environment.Exit(1);
                }
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

    }
}
