using System;
using Antlr4.Runtime;

namespace VKScript.VkScript
{
    public class LexerErrorListener : IAntlrErrorListener<int>
    {
        public void SyntaxError(IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine,
            string msg,
            RecognitionException e)
        {
            ConsoleLogger.Log("Parse error (" + line + ":" + charPositionInLine + "): " + msg, ConsoleColor.Red);
        }
    }
}