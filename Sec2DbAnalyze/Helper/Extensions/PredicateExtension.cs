using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Sec2DbAnalyze.Domain.Abstract;

namespace Sec2DbAnalyze.Helper.Extensions
{
    public static class PredicateExtension
    {
        public static Expression<Func<TEntity, bool>> True<TEntity>() where TEntity : IEntity
        {
            return entity => true;
        }

        public static Expression<Func<TEntity, bool>> False<TEntity>() where TEntity : IEntity
        {
            return entity => false;
        }


        public static Expression<Func<TEntity, bool>> Or<TEntity>(this Expression<Func<TEntity, bool>> expr1,
            Expression<Func<TEntity, bool>> expr2) where TEntity : IEntity
        {
            var parameterExpression = expr1.Parameters[0];

            var visitor = new SubstExpressionVisitor
            {
                Subst =
                {
                    [expr2.Parameters[0]] = parameterExpression
                }
            };

            Expression body = Expression.OrElse(expr1.Body, visitor.Visit(expr2.Body));
            return Expression.Lambda<Func<TEntity, bool>>(body, parameterExpression);
        }

        public static Expression<Func<TEntity, bool>> And<TEntity>(this Expression<Func<TEntity, bool>> expr1,
            Expression<Func<TEntity, bool>> expr2) where TEntity : IEntity
        {
            var parameterExpression = expr1.Parameters[0];

            var visitor = new SubstExpressionVisitor
            {
                Subst =
                {
                    [expr2.Parameters[0]] = parameterExpression
                }
            };

            Expression body = Expression.AndAlso(expr1.Body, visitor.Visit(expr2.Body));
            return Expression.Lambda<Func<TEntity, bool>>(body, parameterExpression);
        }
    }


    internal class SubstExpressionVisitor : ExpressionVisitor
    {
        public readonly Dictionary<Expression, Expression> Subst = new();

        protected override Expression VisitParameter([NotNull] ParameterExpression node)
        {
            return Subst.GetValueOrDefault(node, node);
        }
    }
}