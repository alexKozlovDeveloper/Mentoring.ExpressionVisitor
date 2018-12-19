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
        private Dictionary<string, int> _replaceParams;

        public ParamReplaceVisitor()
        {

        }

        public ParamReplaceVisitor(Dictionary<string,int> replaceParams)
        {
            _replaceParams = replaceParams;
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            var left = CheckParam(node.Left);
            var right = CheckParam(node.Right);

            node = node.Update(left, node.Conversion, right);

            return base.VisitBinary(node);
        }

        private Expression CheckParam(Expression exp)
        {
            if (exp.NodeType != ExpressionType.Parameter)
            {
                return exp;
            }

            var param = exp as ParameterExpression;

            if (_replaceParams.Keys.Contains(param.Name) == false)
            {
                return exp;
            }

            var value = _replaceParams[param.Name];

            return Expression.Constant(value);
        }


        //private ParameterExpression GetParameter(BinaryExpression node)
        //{
        //    if (node.Left.NodeType == ExpressionType.Parameter)
        //    {
        //        return node.Left as ParameterExpression;
        //    }

        //    if (node.Right.NodeType == ExpressionType.Parameter)
        //    {
        //        return node.Right as ParameterExpression;
        //    }

        //    return null;
        //}
    }
}
