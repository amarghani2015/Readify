using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MyServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        #region FibonacciNumber
        [TestMethod]
        //test same result for fibonatcci index number 5  
        public void TestFibonacciNumber1()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            long res = cl.FibonacciNumber(5);
            long res2 = cl2.FibonacciNumber(5);
            Assert.IsTrue(res == res2);
        }
        [TestMethod]
        //test same result for fibonatcci index number 92   
        public void TestFibonacciNumber2()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            long res = cl.FibonacciNumber(92);
            long res2 = cl2.FibonacciNumber(92);
            Assert.IsTrue(res == res2);
        }
        [TestMethod]
        //test same result for fibonatcci index number 0
        public void TestFibonacciNumber3()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            long res = cl.FibonacciNumber(0);
            long res2 = cl2.FibonacciNumber(0);
            Assert.IsTrue(res == res2);
        }
        [TestMethod]
        //test same result for fibonatcci nigative index number
        public void TestFibonacciNumber4()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            long res = cl.FibonacciNumber(-5);
            long res2 = cl2.FibonacciNumber(-5);
            Assert.IsTrue(res == res2);
        }
        [TestMethod]
        //test same result for fibonatcci index number 100
        public void TestFibonacciNumber5()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            string FaultMessage = "";
            try
            {
                cl.FibonacciNumber(100);
                Assert.Fail();
            }
            catch(Exception ex)
            {
                FaultMessage = ex.Message;
                //Assert.AreEqual(ex.Message, "Fib(>92) will cause a 64-bit integer overflow.\r\nParameter name: n ");
            }
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string FaultMessage2 = "";
            try
            {
                cl2.FibonacciNumber(100);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                FaultMessage2 = ex.Message;
                //Assert.AreEqual(ex.Message, "Fib(>92) will cause a 64-bit integer overflow.\r\nParameter name: n ");
            }
            Assert.AreEqual(FaultMessage, FaultMessage2);
        }
        #endregion
        #region ReverseWord
        [TestMethod]
        //test same result for reverse word for abcd
        public void TestReverseWords1()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            string res = cl.ReverseWords("abcd");
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res2 = cl2.ReverseWords("abcd");
            Assert.AreEqual(res, res2);
        }
        [TestMethod]
        //test same result for reverse word for empty string
        public void TestReverseWords2()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            string FaultMessage="", FaultMessage2 = "";
            try
            {
                string res = cl.ReverseWords("");
            }
            catch(Exception ex)
            {
                FaultMessage = ex.Message;
            }
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            try
            {
                string res2 = cl2.ReverseWords("");
            }
            catch(Exception ex)
            {
                FaultMessage2 = ex.Message;
            }
            Assert.AreEqual(FaultMessage, FaultMessage2);
        }
        [TestMethod]
        //test same result for reverse word for null
        public void TestReverseWords3()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            string FaultMessage = "", FaultMessage2 = "";
            try
            {
                string res = cl.ReverseWords(null);
            }
            catch (Exception ex)
            {
                FaultMessage = ex.Message;
            }
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            try
            {
                string res2 = cl2.ReverseWords(null);
            }
            catch (Exception ex)
            {
                FaultMessage2 = ex.Message;
            }
            Assert.AreEqual(FaultMessage, FaultMessage2);
        }
        #endregion
        #region WhatShapeIsThis
        [TestMethod]
        //test same result for whatshapIsThis for shap a=10, b=10, c=10
        public void TestWhatShapeIsThis1()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(10, 10, 10).ToString();
            string res2 = cl2.WhatShapeIsThis(10, 10, 10).ToString();
            Assert.AreEqual(res, res2);
           
        }
        [TestMethod]
        //test same result for whatshapIsThis for shap a=10, b=10, c=5
        public void TestWhatShapeIsThis2()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(10, 10, 5).ToString();
            string res2 = cl2.WhatShapeIsThis(10, 10, 5).ToString();
            Assert.AreEqual(res, res2);

        }
        [TestMethod]
        //test same result for whatshapIsThis for shap a=10, b=7, c=5
        public void TestWhatShapeIsThis3()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(10, 7, 5).ToString();
            string res2 = cl2.WhatShapeIsThis(10, 7, 5).ToString();
            Assert.AreEqual(res, res2);

        }
        [TestMethod]
        //test same result for whatshapIsThis for shap a=10, b=10, c=55
        public void TestWhatShapeIsThis4()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(10, 10, 55).ToString();
            string res2 = cl2.WhatShapeIsThis(10, 10, 55).ToString();
            Assert.AreEqual(res, res2);

        }
        [TestMethod]
        //test same result for whatshapIsThis for shap a=-10, b=10, c=55
        public void TestWhatShapeIsThis5()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(-10, 10, 55).ToString();
            string res2 = cl2.WhatShapeIsThis(-10, 10, 55).ToString();
            Assert.AreEqual(res, res2);

        }
        [TestMethod]
        //test same result for whatshapIsThis for shap a=0, b=10, c=55
        public void TestWhatShapeIsThis6()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(0, 10, 55).ToString();
            string res2 = cl2.WhatShapeIsThis(0, 10, 55).ToString();
            Assert.AreEqual(res, res2);

        }
        [TestMethod]
        //test same result for whatshapIsThis for shap a=10, b=-10, c=55
        public void TestWhatShapeIsThis7()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(10, -10, 55).ToString();
            string res2 = cl2.WhatShapeIsThis(10, -10, 55).ToString();
            Assert.AreEqual(res, res2);

        }
        [TestMethod]
        //test same result for whatshapIsThis for shap a=10, b=0, c=55
        public void TestWhatShapeIsThis8()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(10, 0, 55).ToString();
            string res2 = cl2.WhatShapeIsThis(10, 0, 55).ToString();
            Assert.AreEqual(res, res2);

        }
        [TestMethod]
        //test same result for whatshapIsThis for shap a=10, b=10, c=-55
        public void TestWhatShapeIsThis9()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(10, 10, -55).ToString();
            string res2 = cl2.WhatShapeIsThis(10, 10, -55).ToString();
            Assert.AreEqual(res, res2);

        }
        [TestMethod]
        //test same result for whatshapIsThis for shap a=10, b=10, c=0
        public void TestWhatShapeIsThis10()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(10, 10, 0).ToString();
            string res2 = cl2.WhatShapeIsThis(10, 10, 0).ToString();
            Assert.AreEqual(res, res2);

        }
        [TestMethod]
        //test same result for whatshapIsThis for shap a=0, b=0, c=0
        public void TestWhatShapeIsThis11()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(0, 0, 0).ToString();
            string res2 = cl2.WhatShapeIsThis(0, 0, 0).ToString();
            Assert.AreEqual(res, res2);

        }
        [TestMethod]
        //test same result for whatshapIsThis for shap a=-10, b=-10, c=-10
        public void TestWhatShapeIsThis12()
        {
            MyService.RedPillClient cl = new MyService.RedPillClient();
            ReadifyService.RedPillClient cl2 = new ReadifyService.RedPillClient();
            string res = cl.WhatShapeIsThis(-10, -10, -10).ToString();
            string res2 = cl2.WhatShapeIsThis(-10, -10, -10).ToString();
            Assert.AreEqual(res, res2);

        }
        #endregion

    }
}
