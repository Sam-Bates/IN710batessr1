using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestStack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Push_NewStackThenPeek_ReturnsString()
        {
            Stack.StackList stack = new Stack.StackList();

            String expected = "String";
            stack.Push(expected);

            String actual = stack.Peek();
            Assert.AreEqual("String", actual);
        }
        [TestMethod]
        public void Push_PushToStackCallCount_Returns2()
        {
            Stack.StackList stack = new Stack.StackList();

            int expected = 2;
            stack.Push("str");
            stack.Push("str1");
            int actual = stack.Count();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_PopCalledNewStack_Exception()
        {
            Stack.StackList stack = new Stack.StackList();
            stack.Pop();
            Assert.Fail();
        }
    }
}
