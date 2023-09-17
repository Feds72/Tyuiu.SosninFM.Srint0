using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SosninFM.Sprint0.Task2.V0.Lib;
using System;

namespace Tyuiu.SosninFM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Фёдор";
            var res = DataService .GetMessage(name);

            Assert.AreEqual("Привет..., Фёдор", res);
        }
    }
}
