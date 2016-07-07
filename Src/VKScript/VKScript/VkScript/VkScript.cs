using System;
using System.IO;
using Antlr4.Runtime;

namespace VKScript.VkScript
{
    public class VkScript
    {
        private static readonly LexerErrorListener LexerErrorListener = new LexerErrorListener();
        private static readonly ParserErrorListener ParserErrorListener = new ParserErrorListener();
        private readonly Visitor _visitor;

        public VkScript(Visitor v)
        {
            _visitor = v;
        }

        public void Exec(string line)
        {
            try
            {
                var lexer =
                    new VKScriptLexer(new AntlrInputStream(GenerateStreamFromString(line)));
                lexer.RemoveErrorListeners();
                lexer.AddErrorListener(LexerErrorListener);

                var parser = new VKScriptParser(new CommonTokenStream(lexer));
                parser.RemoveErrorListeners();
                parser.AddErrorListener(ParserErrorListener);

                var tree = parser.vk_script();
                _visitor.Visit(tree);
            }
            catch (Exception ex)
            {
                ConsoleLogger.Log("Runtime error: " + ex.Message, ConsoleColor.Red);
            }
        }

        public static void RunVkScript(string script)
        {
            var visitor = new Visitor(false);
            try
            {
                var lexer = new VKScriptLexer(new AntlrInputStream(GenerateStreamFromString(script)));
                lexer.RemoveErrorListeners();
                lexer.AddErrorListener(LexerErrorListener);

                var parser = new VKScriptParser(new CommonTokenStream(lexer));
                parser.RemoveErrorListeners();
                parser.AddErrorListener(ParserErrorListener);

                var tree = parser.vk_script();
                visitor.Visit(tree);
            }
            catch (Exception ex)
            {
                ConsoleLogger.Log("Runtime error: " + ex.Message, ConsoleColor.Red);
            }
        }

        private static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}