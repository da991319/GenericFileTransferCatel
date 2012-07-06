using GenericFileTransfer2.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Catel.MVVM;

namespace TestGenericFileTransfer
{
    
    
    /// <summary>
    ///This is a test class for MainWindowViewModelTest and is intended
    ///to contain all MainWindowViewModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MainWindowViewModelTest
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
        ///A test for MainWindowViewModel Constructor
        ///</summary>
        [TestMethod()]
        public void MainWindowViewModelConstructorTest()
        {
            MainWindowViewModel target = new MainWindowViewModel();

            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for OnAddReportCanExecute
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GenericFileTransfer2.exe")]
        public void OnAddReportCanExecuteTest()
        {
            MainWindowViewModel_Accessor target = new MainWindowViewModel_Accessor();
            target.CurrentViewModel = new ReportViewModel();
            bool actual;
            actual = target.OnAddReportCanExecute();
            Assert.IsFalse(actual);

            target.CurrentViewModel = new HomeViewModel();
            actual = target.OnAddReportCanExecute();
            Assert.IsTrue(actual);

        }

        /// <summary>
        ///A test for OnAddReportExecute
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GenericFileTransfer2.exe")]
        public void OnAddReportExecuteTest()
        {
            MainWindowViewModel_Accessor target = new MainWindowViewModel_Accessor(); 
            target.OnAddReportExecute();
            Assert.IsInstanceOfType(target.CurrentViewModel, typeof(ReportViewModel));
        }

        /// <summary>
        ///A test for OnHomeViewCommandCanExecute
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GenericFileTransfer2.exe")]
        public void OnHomeViewCommandCanExecuteTest()
        {
            MainWindowViewModel_Accessor target = new MainWindowViewModel_Accessor();
            target.CurrentViewModel = new HomeViewModel();
            bool actual;
            actual = target.OnHomeViewCommandCanExecute();
            Assert.IsFalse(actual);

            target.CurrentViewModel = new ReportViewModel();
            actual = target.OnHomeViewCommandCanExecute();
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for OnHomeViewCommandExecute
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GenericFileTransfer2.exe")]
        public void OnHomeViewCommandExecuteTest()
        {
            MainWindowViewModel_Accessor target = new MainWindowViewModel_Accessor();
            target.OnHomeViewCommandExecute();
            Assert.IsInstanceOfType(target.CurrentViewModel, typeof(HomeViewModel));
        }

        /// <summary>
        ///A test for AddReport
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GenericFileTransfer2.exe")]
        public void AddReportTest()
        {
            MainWindowViewModel_Accessor target = new MainWindowViewModel_Accessor();
            Assert.IsNotNull(target.AddReport);
            Assert.IsInstanceOfType(target.AddReport,typeof(Command));
        }

        /// <summary>
        ///A test for CurrentViewModel
        ///</summary>
        [TestMethod()]
        public void CurrentViewModelTest()
        {
            MainWindowViewModel target = new MainWindowViewModel(); 
            ViewModelBase expected = new ReportViewModel(); 
            ViewModelBase actual;
            target.CurrentViewModel = expected;
            actual = target.CurrentViewModel;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for HomeViewCommand
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GenericFileTransfer2.exe")]
        public void HomeViewCommandTest()
        {
            MainWindowViewModel_Accessor target = new MainWindowViewModel_Accessor();
            Assert.IsNotNull(target.HomeViewCommand);
            Assert.IsInstanceOfType(target.HomeViewCommand, typeof(Command));
        }
    }
}
