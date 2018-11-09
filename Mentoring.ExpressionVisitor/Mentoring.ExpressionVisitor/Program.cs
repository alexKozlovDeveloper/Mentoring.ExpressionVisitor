using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring.MyExpressionVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int>> exp1 = (a) => ((1 - a)*(a - 1)*(1 + a) + (a + 1) * (18 * a))/(a - 1 + a + 2 + 1 + a);

            Console.WriteLine(exp1);

            var exp2 = (new ParamReplaceVisitor().VisitAndConvert(exp1, ""));

            Console.WriteLine(exp2);
        }
    }

    
}
