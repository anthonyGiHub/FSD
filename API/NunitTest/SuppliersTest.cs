using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using WebApi.Controllers;
using System.Web.Mvc;
using WebApi.Models;


namespace NunitTest
{
    [TestFixture]
    class SuppliersTest
    {
        [Test]
        public void TestSupllierIndex()
        {
            var obj = new SuppliersController();

            var actResult = obj.Index() as ViewResult;

            Assert.That(actResult.ViewName, Is.EqualTo("Index"));
        }
    }
}
