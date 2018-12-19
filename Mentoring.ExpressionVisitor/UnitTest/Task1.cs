using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Mentoring.MyExpressionVisitor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Task1
    {
        [TestMethod]
        public void TestIncDec()
        {
            Expression<Func<int, int>> exp1 = (a) => (a + 1) * (1 + a) + (a - 1) * (1 - a) + a * a + 1 + (a - 1) + (a + 1);

            Console.WriteLine(exp1);

            var exp2 = (new IncDecVisitor().VisitAndConvert(exp1, ""));

            Console.WriteLine(exp2);
        }

        [TestMethod]
        public void TestParam()
        {
            Expression<Func<int, int>> exp1 = (a) => a + 2 + (a + 2);

            Console.WriteLine(exp1);

            var replaceParams = new Dictionary<string, int>();

            replaceParams.Add("a", 99);

            var exp2 = (new ParamReplaceVisitor(replaceParams).VisitAndConvert(exp1, ""));

            Console.WriteLine(exp2);
        }
    }
}
