using System;
using System.Linq.Expressions;
using Sec2DbAnalyze.Domain.Abstract;
using Sec2DbAnalyze.Dto.Abstract;

namespace Sec2DbAnalyze.Helper.Extensions
{
    public static class FilterExtension
    {
        public static Expression<Func<TEntity, bool>> ToQuery<TEntity, TDto>(this TDto dto,
            QueryOperators queryOperators = QueryOperators.And)
            where TEntity : class, IEntity, new()
            where TDto : class, IDto, new()
        {
            return GetFilledPropertiesFilter<TEntity, TDto>(dto, queryOperators);
        }

        private static Expression<Func<TEntity, bool>> GetFilledPropertiesFilter<TEntity, TDto>(TDto dto,
            QueryOperators queryOperators)
        {
            var parameter = Expression.Parameter(typeof(TEntity), "entity");
            Expression filterExpression = Expression.Constant(true);

            foreach (var property in typeof(TDto).GetProperties())
            {
                var propertyValue = property.GetValue(dto);
                if (propertyValue == null) continue;
                var propertyExpression = Expression.Property(parameter, property.Name);
                var valueExpression = Expression.Constant(propertyValue);
                var equalityExpression = Expression.Equal(propertyExpression, valueExpression);
                filterExpression = queryOperators == QueryOperators.And
                    ? Expression.AndAlso(filterExpression, equalityExpression)
                    : Expression.OrElse(filterExpression, equalityExpression);
            }

            return Expression.Lambda<Func<TEntity, bool>>(filterExpression, parameter);
        }
    }

    public enum QueryOperators
    {
        And,
        Or
    }
}