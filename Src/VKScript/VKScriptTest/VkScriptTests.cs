using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VKScript.VkScript;

namespace VKScriptTest
{
    [TestClass]
    public class VkScriptTests
    {
        [TestMethod]
        public void TestPrintInt()
        {
            var script = @"print(123)";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("123\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestPrintString()
        {
            var script = @"print(""word w"")";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("word w\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestPrintPair()
        {
            var script = @"print(test: 25)";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("test : 25\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestSimpleMath()
        {
            var script = @"print((((24+3)-(17+4))+8))";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("14\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestComplexMath()
        {
            var script = @"print(((1 + (((((24+3)-(17+4))+8) / 2) * 47)) / 11 + 1 - 8))";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("23\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestExpressionsEvaluatedInOrder()
        {
            var script = @"print((1 + 2 * 3 - 5 * 7))";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("-28\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestIntToStringCast()
        {
            var script = @"a = 21
b = ""string""
c = a + b
print(c)";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("21string\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestStringToIntCast()
        {
            var script = @"a = ""21""
b = int(a)
c = b + 1
print(c)";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("22\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestSimpleBool()
        {
            var script = @"a = 5 > 2
print(a)";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("True\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestComplexBool()
        {
            var script = @"a = (5 > 2) && ((21*3) < 50)
print(a)";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("False\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestSimpleIf()
        {
            var script = @"if (5 > 2) { print(""true"") } else { print(""false"") }";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("true\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestNestedIf()
        {
            var script = @"if (5 < 2) {

if (2 > 3) {
        print(1)
} else {
        print(2)
}

} else {

if (7 < 4) {
        print(3)
} else {
        print(4)
}

}";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("4\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestSimpleWhile()
        {
            var script = @"i = 0
while (i < 5) {

print(i)
i = i + 1
}
print(i)";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("0\r\n1\r\n2\r\n3\r\n4\r\n5\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestWhileWithIf()
        {
            var script = @"i = 0
while (i < 10) {
if (i % 2 == 1) {
print(i)
}
i = i + 1
}
print(i)";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("1\r\n3\r\n5\r\n7\r\n9\r\n10\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestCopyValue()
        {
            var script = @"a = 1
b = a
a = 2
print({a, b})";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("{2, 1}\r\n", tw.ToString());
        }
    }
}