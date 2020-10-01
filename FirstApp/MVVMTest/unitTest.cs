using System;
using FirstApp.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVVMTest
{
    [TestClass]
    public class unitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            StudentViewModel sViewModel = new StudentViewModel();
            int count = sViewModel.GetStudentCount();
            Assert.IsTrue(count == 3);
        }
    }
}
