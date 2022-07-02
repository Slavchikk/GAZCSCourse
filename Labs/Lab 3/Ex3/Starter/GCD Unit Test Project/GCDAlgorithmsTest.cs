using GreatestCommonDivisor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GCDTestProject
{


    /// <summary>
    ///This is a test class for GCDAlgorithmsTest and is intended
    ///to contain all GCDAlgorithmsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GCDAlgorithmsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        // TODO Exercise 3, Task 3
        // Modify all tests to include timing parameter

        /// <summary>
        ///A test for findGCDEuclid
        ///</summary>
        //[TestMethod()]
        public void FindGCDEuclidTest()
        {
            int a = 298467352;
            int b = 569484;
            int expected = 4;
            int actual;
            long time;
            actual = GCDAlgorithms.FindGCDEuclid(a, b, out time);
            Assert.AreEqual(expected, actual);
        }

        

    }
}
namespace Module_3_Unit_Test_Project
{
    
    
    /// <summary>
    ///This is a test class for GCDAlgorithmsTest and is intended
    ///to contain all GCDAlgorithmsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GCDAlgorithmsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for FindGCDStein
        ///</summary>
        [TestMethod()]
        public void FindGCDSteinTest()
        {
            int u = 298467352; // TODO: Initialize to an appropriate value
            int v = 569484; // TODO: Initialize to an appropriate value
            long time = 0; // TODO: Initialize to an appropriate value    
            int expected = 4; // TODO: Initialize to an appropriate value
            int actual;
            actual = GCDAlgorithms.FindGCDStein(u, v, out time);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
