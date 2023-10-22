using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint3.Task3.V22.Lib;

namespace Tyuiu.ChazovaSR.Sprint3.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {

            DataService ds = new DataService();

            string str = " tbtbbb dsfbg bbg ";
            char chr = 't';

            int res = ds.GetMaxCharCount(str, chr);

            double wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
