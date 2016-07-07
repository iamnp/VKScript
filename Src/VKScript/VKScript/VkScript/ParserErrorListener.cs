using System;
using Antlr4.Runtime;

namespace VKScript.VkScript
{
    public class ParserErrorListener : IAntlrErrorListener<IToken>
    {
        public void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine,
            string msg,
            RecognitionException e)
        {
            ConsoleLogger.Log("Parse error (" + line + ":" + charPositionInLine + "): " + msg, ConsoleColor.Red);
        }
    }
}