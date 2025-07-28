using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_3_skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Assignment_3_1.
{
    [TestClass]
    public class AdditionalTests
    {
        private SLL list;

        [TestInitialize]
        public void Setup()
        {
            list = new SLL();
      
        }

        [TestMethod]
        public void Test_Clear()
        {
            list.Append("one");
            list.Append("two");
            list.Clear();
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void Test_ContainsFalseOnNewList()
        {
            Assert.IsFalse(list.Contains("one"));
        }

        [TestMethod]
        public void Test_ContainsTrueAfterAppend()
        {
            list.Append("one");
            Assert.IsTrue(list.Contains("one"));
        }

        [TestMethod]
        public void Test_SizeAfterOperations()
        {
            list.Append("one");
            list.Append("two");
            list.Prepend("three");
            Assert.AreEqual(3, list.Size());

            list.Clear(0);
            Assert.AreEqual(0, list.Size());

            list.Clear(list.Size() - 1);
            Assert.AreEqual(1, list.Size()); ;
        }
    }
}
