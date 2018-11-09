﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mentoring.MyExpressionVisitor
{
    public class MappingGenerator
    {
        public Mapper<TSource, TDestination> Generate<TSource, TDestination>()
        {
            var sourceParam = Expression.Parameter(typeof(TSource));
            var mapFunction =
                Expression.Lambda<Func<TSource, TDestination>>(
                Expression.New(typeof(TDestination)),
                sourceParam
                );

            return new Mapper<TSource, TDestination>(mapFunction.Compile());
        }
    }
}
