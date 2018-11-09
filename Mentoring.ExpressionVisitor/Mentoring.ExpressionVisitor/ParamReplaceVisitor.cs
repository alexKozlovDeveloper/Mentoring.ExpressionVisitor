using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring.MyExpressionVisitor
{
    public class ParamReplaceVisitor : ExpressionVisitor
    {
        //override 
        protected override Expression VisitBinary(BinaryExpression node)
        {
            //var parameter = GetParameter(node);
            //var constant = GetConstant(node);

            //if (parameter == null || constant == null)
            //{
            //    return base.VisitBinary(node);
            //}

            //if (node.NodeType == ExpressionType.Add)
            //{
            //    if (constant.Type == typeof(int) && (int)constant.Value == 1)
            //    {
            //        return Expression.Increment(parameter);
            //    }
            //}

            //if (node.NodeType == ExpressionType.Subtract)
            //{
            //    if (constant.Type == typeof(int) && (int)constant.Value == 1)
            //    {
            //        if (node.Left.NodeType == ExpressionType.Parameter)
            //        {
            //            return Expression.Decrement(parameter);
            //        }
            //    }
            //}

            return base.VisitBinary(node);
        }

        
    }
}
