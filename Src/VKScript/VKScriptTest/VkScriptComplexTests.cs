using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VKScript.VkScript;

namespace VKScriptTest
{
    [TestClass]
    public class VkScriptComplexTests
    {
        [TestMethod]
        public void TestFactorial()
        {
            var script = @"i = 10
fact = 1
while (i > 0) {
fact = fact * i
i = i - 1
}
print(fact)";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("3628800\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestFibonacci()
        {
            var script = @"i = 10
a = 1
b = 1
print(a)
print(b)
while (i > 0) {
c = a+b
a = b
b = c
print(c)
i = i - 1
}";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("1\r\n1\r\n2\r\n3\r\n5\r\n8\r\n13\r\n21\r\n34\r\n55\r\n89\r\n144\r\n",
                tw.ToString());
        }

        [TestMethod]
        public void TestSquareList()
        {
            var script = @"a = {3, 4, 5, 6, 7, 8, 9, 10, 11, 12}
b = {}
i = 0
while (i < 10) {
t = a.at(pos:i)
b = b.append(t*t)
i = i + 1
}
print(b)";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("{9, 16, 25, 36, 49, 64, 81, 100, 121, 144}\r\n",
                tw.ToString());
        }
    }
}