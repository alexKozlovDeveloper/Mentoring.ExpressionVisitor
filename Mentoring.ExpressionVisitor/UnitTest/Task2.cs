using System;
using Mentoring.MyExpressionVisitor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Task2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mapGenerator = new MappingGenerator();
            var mapper = mapGenerator.Generate<Foo, Bar>();

            Bar res = mapper.Map(new Foo());
        }
    }
}
