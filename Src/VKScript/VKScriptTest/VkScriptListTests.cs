using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VKScript.VkScript;

namespace VKScriptTest
{
    [TestClass]
    public class VkScriptListTests
    {
        [TestMethod]
        public void TestListFirst()
        {
            var script = @"a = { item1 : {a:1, b:2}, item2 : { c:3, d:4} }
print({ a.first() })";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("item1 : {a : 1, b : 2}\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestListLast()
        {
            var script = @"a = { item1 : {a:1, b:2}, item2 : { c:3, d:4} }
print({ a.last() })";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("item2 : {c : 3, d : 4}\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestListAt()
        {
            var script = @"list = { 1, 2, 3, ""a"", ""b"", ""c"" }
print({ list.at({ pos:2 }) })";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("3\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestListTakeCount()
        {
            var script = @"list = { 1, 2, 3, ""a"", ""b"", ""c"" }
print({ list.take({ count:2 }) })";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("{1, 2}\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestListTakeCountFrom()
        {
            var script = @"list = { 1, 2, 3, ""a"", ""b"", ""c"" }
print({ list.take({ count:3, from: 2 }) })";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("{3, a, b}\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestListAppend()
        {
            var script = @"list = { 1, 2, 3, ""a"", ""b"", ""c"" }
list2 = list.append({ ""text"", 123, ""text"" })
print({ list2 })";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("{1, 2, 3, a, b, c, text, 123, text}\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestListRemove()
        {
            var script = @"list = { 1, 2, 3, ""a"", ""b"", ""c"" }
list2 = list.remove({ pos: 3 })
print({ list2 })";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("{1, 2, 3, b, c}\r\n", tw.ToString());
        }

        [TestMethod]
        public void TestListByKey()
        {
            var script = @"list = { a:1, b:2, c:3, d:4, e:5 }
print({ list.byKey({ ""c"" }) })";
            var tw = new StringWriter();
            Console.SetOut(tw);
            VkScript.RunVkScript(script);
            Assert.AreEqual("3\r\n", tw.ToString());
        }
    }
}