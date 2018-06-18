using System;
using Parser.Core;
using Parser.Core.Habra;

namespace Parcer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            FormWorker fw1 = new FormWorker();
            fw1.button1_Click();

            Console.ReadKey();
        }
    }

    class FormWorker
    {
        ParserWorker<string[]> parser;
        public FormWorker()
        {
            parser = new ParserWorker<string[]>(
               new GorodParser()
           );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }


        public void button1_Click()
        {
            parser.Settings = new GorodSettings(1, 3);
            parser.Start();
        }

        public void button2_Click()
        {
            parser.Abort();
        }


        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            //foreach (var st in arg2)
            //    Console.WriteLine(st);
        }

        private void Parser_OnCompleted(object obj)
        {
            Console.WriteLine("All works done!");
        }
    }


}
