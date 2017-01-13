using System.Collections.Generic;
using System.Linq;

namespace YamDocumentManagementSystem.Types.General
{
    public static class LinqExtensions
    {
        public static IEnumerable<T> WhereIsNotNull<T>(this IEnumerable<T> items) => items.Where(item => item != null);

        public static IEnumerable<T> UnionWhereIsNotNull<T>(this IEnumerable<T> items, IEnumerable<T> otherItems)
            => items.WhereIsNotNull().Union(otherItems.WhereIsNotNull());

        public static IEnumerable<T> WhereIsNotNullWhileDistinct<T>(this IEnumerable<T> items,
            IEqualityComparer<T> equalityComparer) => items.WhereIsNotNull().Distinct(equalityComparer);

        public static IEnumerable<T> UnionWhereIsNotNullWhileDistinct<T>(this IEnumerable<T> items,
            IEnumerable<T> otherItems, IEqualityComparer<T> equalityComparer)
            => items.UnionWhereIsNotNull(otherItems).Distinct(equalityComparer);
    }
}