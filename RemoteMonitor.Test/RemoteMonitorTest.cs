using RemoteMonitor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Rhino.Mocks;
using Rhino.Mocks;

namespace RemoteMonitor.Test
{
    
    
    /// <summary>
    ///This is a test class for RemoteMonitorTest and is intended
    ///to contain all RemoteMonitorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RemoteMonitorTest
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
        ///A test for ReadValue
        ///</summary>
        [TestMethod()]
        public void ReadValueTest()
        {
            RemoteMonitor target = new RemoteMonitor(); // TODO: Initialize to an appropriate value
            RemoteVar remoteVar = null; // TODO: Initialize to an appropriate value
            target.ReadValue(remoteVar);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for WriteValue
        ///</summary>
        [TestMethod()]
        public void WriteValueTest()
        {
            MockRepository mocks = new MockRepository();

            RemoteMonitor target = new RemoteMonitor(); // TODO: Initialize to an appropriate value
            IMonitorGateway gateway = mocks.StrictMock<IMonitorGateway>();                        

            target.MonitorGateway = gateway;
            RemoteVar remoteVar = new RemoteVar();

            Expect.On(gateway.ReadValue(remoteVar));

            target.WriteValue(remoteVar);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
