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
        [TestMethod]
        public void Pop_PushnStringToStackThenPop_ReturnsString()
        {
            Stack.StackList stack = new Stack.StackList();
            String expected = "a";
            stack.Push("String");
            stack.Push(expected);
            String actual = stack.Pop();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Pop_Push1StringToStackThenPop_ReturnsString()
        {
            Stack.StackList stack = new Stack.StackList();
            String expected = "a";
            stack.Push(expected);
            String actual = stack.Pop();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Peek_EmptyStack_Exception()
        {
            Stack.StackList stack = new Stack.StackList();
            stack.Peek();
            Assert.Fail();
        }
        [TestMethod]
        public void Peek_PushSeveralItems_String()
        {
            Stack.StackList stack = new Stack.StackList();
            String expected = "string";
            stack.Push("");
            stack.Push(expected);
            String actual = stack.Peek();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Count_NewStack_int()
        {
            Stack.StackList stack = new Stack.StackList();
            int expected = 0;
            int actual = stack.Count();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Count_PushThenCount_int()
        {
            Stack.StackList stack = new Stack.StackList();
            int expected = 2;
            stack.Push("string");
            stack.Push("String1");
            int actual = stack.Count();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Count_CountCalledOnceAllStringsPopped_int()
        {
            Stack.StackList stack = new Stack.StackList();
            int expected = 0;
            stack.Push("string");
            stack.Push("String1");
            stack.Pop();
            stack.Pop();
            int actual = stack.Count();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void isEmpty_NewStack_true()
        {
            Stack.StackList stack = new Stack.StackList();
            bool expected = true;
            bool actual = stack.IsEmpty();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void isEmpty_AllStringsPopped_true()
        {
            Stack.StackList stack = new Stack.StackList();
            stack.Push("a");
            stack.Pop();
            bool expected = true;
            bool actual = stack.IsEmpty();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void isEmpty_NotEmptyStack_false()
        {
            Stack.StackList stack = new Stack.StackList();
            stack.Push("a");
            bool expected = false;
            bool actual = stack.IsEmpty();
            Assert.AreEqual(expected, actual);
        }

    }
}
