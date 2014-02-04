using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bql_format_tool
{
    class Formatter
    {
        private readonly TextReader _input;
        private readonly TextWriter _output;

        public Formatter(TextReader input, TextWriter output)
        {
            _input = input;
            _output = output;
        }

        public void Format()
        {
            int ident = 0;
            while (_input.Peek() != -1)
            {
                var c = (char) _input.Read();
                
                _output.Write(c);

                if (c == '<')
                {
                    ident++;
                    _output.Write("\n{0," + (ident * 2) + "}", "");
                }

                if (c == '>')
                {
                    ident--;
                    _output.Write("\n{0," + (ident * 2) + "}", "");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            (new Formatter(Console.In, Console.Out)).Format();
        }
    }
}
