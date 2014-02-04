using System;
using System.IO;

namespace bql_format_tool
{
    internal class Formatter
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

                if (!char.IsWhiteSpace(c))
                {
                    _output.Write(c);

                    if (c == '<')
                    {
                        ident++;
                        NextLine(ident);
                    }

                    if (c == '>')
                    {
                        ident--;
                        if ((char) _input.Peek() != '>' && (char) _input.Peek() != ',')
                        {
                            NextLine(ident);
                        }
                    }

                    if (c == ',')
                    {
                        NextLine(ident);
                    }
                }
            }
        }

        private void NextLine(int ident)
        {
            _output.Write("\n{0," + (ident*4) + "}", "");
        }
    }

    internal class Program
    {
        private static void Main()
        {
            (new Formatter(Console.In, Console.Out)).Format();
        }
    }
}