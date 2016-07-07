using System;

namespace VKScript.VkScript
{
    public static class ConsoleLogger
    {
        public static void Log(string msg, ConsoleColor color)
        {
            var initialColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ForegroundColor = initialColor;
        }
    }
}