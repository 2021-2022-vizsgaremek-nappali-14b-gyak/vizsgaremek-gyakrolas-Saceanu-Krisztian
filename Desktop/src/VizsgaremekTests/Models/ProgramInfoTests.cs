
using Vizsgaremek.Models;using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Vizsgaremek.Models.Tests
{
    [TestClass()]
    public class ProgramInfoTests
    {
        [TestMethod()]
        public void ProgramInfoTestVersion()
        {
            //arrange

            ProgramInfo programinfo = new ProgramInfo();
            string expected = "0.0.2";

            //act
            string actual = programinfo.Version;

            //assert

            Assert.AreEqual(expected,actual, "Version is not 0.0.2");
        }
    }
}