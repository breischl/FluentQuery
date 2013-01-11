using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace FluentQuery
{
    public static class FluentQueryExtensions
    {
        #region And
        public static TableQuery<T> And<T>(this TableQuery<T> tq, string condition) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.And, condition);
        }

        public static TableQuery<T> And<T>(this TableQuery<T> tq, string attributeName, string op, string operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.And, attributeName, op, operand);
        }

        public static TableQuery<T> And<T>(this TableQuery<T> tq, string attributeName, string op, int operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.And, attributeName, op, operand);
        }

        public static TableQuery<T> And<T>(this TableQuery<T> tq, string attributeName, string op, long operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.And, attributeName, op, operand);
        }

        public static TableQuery<T> And<T>(this TableQuery<T> tq, string attributeName, string op, double operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.And, attributeName, op, operand);
        }

        public static TableQuery<T> And<T>(this TableQuery<T> tq, string attributeName, string op, byte[] operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.And, attributeName, op, operand);
        }

        public static TableQuery<T> And<T>(this TableQuery<T> tq, string attributeName, string op, Guid operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.And, attributeName, op, operand);
        }

        public static TableQuery<T> And<T>(this TableQuery<T> tq, string attributeName, string op, DateTime operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.And, attributeName, op, operand);
        }

        public static TableQuery<T> And<T>(this TableQuery<T> tq, string attributeName, string op, bool operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.And, attributeName, op, operand);
        }
        #endregion

        #region Or
        public static TableQuery<T> Or<T>(this TableQuery<T> tq, string condition) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Or, condition);
        }

        public static TableQuery<T> Or<T>(this TableQuery<T> tq, string attributeName, string op, string operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Or, attributeName, op, operand);
        }

        public static TableQuery<T> Or<T>(this TableQuery<T> tq, string attributeName, string op, int operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Or, attributeName, op, operand);
        }

        public static TableQuery<T> Or<T>(this TableQuery<T> tq, string attributeName, string op, long operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Or, attributeName, op, operand);
        }

        public static TableQuery<T> Or<T>(this TableQuery<T> tq, string attributeName, string op, double operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Or, attributeName, op, operand);
        }

        public static TableQuery<T> Or<T>(this TableQuery<T> tq, string attributeName, string op, byte[] operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Or, attributeName, op, operand);
        }

        public static TableQuery<T> Or<T>(this TableQuery<T> tq, string attributeName, string op, Guid operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Or, attributeName, op, operand);
        }

        public static TableQuery<T> Or<T>(this TableQuery<T> tq, string attributeName, string op, DateTime operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Or, attributeName, op, operand);
        }

        public static TableQuery<T> Or<T>(this TableQuery<T> tq, string attributeName, string op, bool operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Or, attributeName, op, operand);
        }
        #endregion

        #region Not
        public static TableQuery<T> Not<T>(this TableQuery<T> tq, string condition) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Not, condition);
        }

        public static TableQuery<T> Not<T>(this TableQuery<T> tq, string attributeName, string op, string operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Not, attributeName, op, operand);
        }

        public static TableQuery<T> Not<T>(this TableQuery<T> tq, string attributeName, string op, int operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Not, attributeName, op, operand);
        }

        public static TableQuery<T> Not<T>(this TableQuery<T> tq, string attributeName, string op, long operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Not, attributeName, op, operand);
        }

        public static TableQuery<T> Not<T>(this TableQuery<T> tq, string attributeName, string op, double operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Not, attributeName, op, operand);
        }

        public static TableQuery<T> Not<T>(this TableQuery<T> tq, string attributeName, string op, byte[] operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Not, attributeName, op, operand);
        }

        public static TableQuery<T> Not<T>(this TableQuery<T> tq, string attributeName, string op, Guid operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Not, attributeName, op, operand);
        }

        public static TableQuery<T> Not<T>(this TableQuery<T> tq, string attributeName, string op, DateTime operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Not, attributeName, op, operand);
        }

        public static TableQuery<T> Not<T>(this TableQuery<T> tq, string attributeName, string op, bool operand) where T : ITableEntity, new()
        {
            return tq.CombineFilter(TableOperators.Not, attributeName, op, operand);
        }

        #endregion 

        #region Where
        public static TableQuery<T> Where<T>(this TableQuery<T> tq, string condition) where T : ITableEntity, new()
        {
            if (!string.IsNullOrEmpty(tq.FilterString))
            {
                throw new InvalidOperationException("Cannot use Where() when query already has filter conditions");
            }

            tq.FilterString = condition;
            return tq;
        }

        public static TableQuery<T> Where<T>(this TableQuery<T> tq, string attributeName, string op, string operand) where T : ITableEntity, new()
        {
            return tq.Where(TableQuery.GenerateFilterCondition(attributeName, op, operand));
        }

        public static TableQuery<T> Where<T>(this TableQuery<T> tq, string attributeName, string op, int operand) where T : ITableEntity, new()
        {
            return tq.Where(TableQuery.GenerateFilterConditionForInt(attributeName, op, operand));
        }

        public static TableQuery<T> Where<T>(this TableQuery<T> tq, string attributeName, string op, long operand) where T : ITableEntity, new()
        {
            return tq.Where(TableQuery.GenerateFilterConditionForLong(attributeName, op, operand));
        }

        public static TableQuery<T> Where<T>(this TableQuery<T> tq, string attributeName, string op, double operand) where T : ITableEntity, new()
        {
            return tq.Where(TableQuery.GenerateFilterConditionForDouble(attributeName, op, operand));
        }

        public static TableQuery<T> Where<T>(this TableQuery<T> tq, string attributeName, string op, byte[] operand) where T : ITableEntity, new()
        {
            return tq.Where(TableQuery.GenerateFilterConditionForBinary(attributeName, op, operand));
        }

        public static TableQuery<T> Where<T>(this TableQuery<T> tq, string attributeName, string op, Guid operand) where T : ITableEntity, new()
        {
            return tq.Where(TableQuery.GenerateFilterConditionForGuid(attributeName, op, operand));
        }

        public static TableQuery<T> Where<T>(this TableQuery<T> tq, string attributeName, string op, DateTime operand) where T : ITableEntity, new()
        {
            return tq.Where(TableQuery.GenerateFilterConditionForDate(attributeName, op, operand));
        }

        public static TableQuery<T> Where<T>(this TableQuery<T> tq, string attributeName, string op, bool operand) where T : ITableEntity, new()
        {
            return tq.Where(TableQuery.GenerateFilterConditionForBool(attributeName, op, operand));
        }

        #endregion 

        #region CombineFilter
        public static TableQuery<T> CombineFilter<T>(this TableQuery<T> tq, string op, string condition) where T : ITableEntity, new()
        {
            tq.FilterString = TableQuery.CombineFilters(tq.FilterString, op, condition);
            return tq;
        }

        public static TableQuery<T> CombineFilter<T>(this TableQuery<T> tq, string op, string attributeName, string comparison, string operand) where T : ITableEntity, new()
        {
            var cond = TableQuery.GenerateFilterCondition(attributeName, comparison, operand);
            tq.FilterString = TableQuery.CombineFilters(tq.FilterString, op, cond);
            return tq;
        }

        public static TableQuery<T> CombineFilter<T>(this TableQuery<T> tq, string op, string attributeName, string comparison, int operand) where T : ITableEntity, new()
        {
            var cond = TableQuery.GenerateFilterConditionForInt(attributeName, comparison, operand);
            tq.FilterString = TableQuery.CombineFilters(tq.FilterString, op, cond);
            return tq;
        }

        public static TableQuery<T> CombineFilter<T>(this TableQuery<T> tq, string op, string attributeName, string comparison, long operand) where T : ITableEntity, new()
        {
            var cond = TableQuery.GenerateFilterConditionForLong(attributeName, comparison, operand);
            tq.FilterString = TableQuery.CombineFilters(tq.FilterString, op, cond);
            return tq;
        }

        public static TableQuery<T> CombineFilter<T>(this TableQuery<T> tq, string op, string attributeName, string comparison, double operand) where T : ITableEntity, new()
        {
            var cond = TableQuery.GenerateFilterConditionForDouble(attributeName, comparison, operand);
            tq.FilterString = TableQuery.CombineFilters(tq.FilterString, op, cond);
            return tq;
        }

        public static TableQuery<T> CombineFilter<T>(this TableQuery<T> tq, string op, string attributeName, string comparison, byte[] operand) where T : ITableEntity, new()
        {
            var cond = TableQuery.GenerateFilterConditionForBinary(attributeName, comparison, operand);
            tq.FilterString = TableQuery.CombineFilters(tq.FilterString, op, cond);
            return tq;
        }

        public static TableQuery<T> CombineFilter<T>(this TableQuery<T> tq, string op, string attributeName, string comparison, DateTime operand) where T : ITableEntity, new()
        {
            var cond = TableQuery.GenerateFilterConditionForDate(attributeName, comparison, operand);
            tq.FilterString = TableQuery.CombineFilters(tq.FilterString, op, cond);
            return tq;
        }

        public static TableQuery<T> CombineFilter<T>(this TableQuery<T> tq, string op, string attributeName, string comparison, Guid operand) where T : ITableEntity, new()
        {
            var cond = TableQuery.GenerateFilterConditionForGuid(attributeName, comparison, operand);
            tq.FilterString = TableQuery.CombineFilters(tq.FilterString, op, cond);
            return tq;
        }

        public static TableQuery<T> CombineFilter<T>(this TableQuery<T> tq, string op, string attributeName, string comparison, bool operand) where T : ITableEntity, new()
        {
            var cond = TableQuery.GenerateFilterConditionForBool(attributeName, comparison, operand);
            tq.FilterString = TableQuery.CombineFilters(tq.FilterString, op, cond);
            return tq;
        }
        #endregion

        /// <summary>
        /// Generates a query filter that will look for RowKeys with the specified prefix.
        /// Usage: (from r in myQuery where r.PartitionKey == "blah" select r).Where(RowKeyHasPrefix("myPrefix")).AsTableServiceQuery().ToList()
        /// </summary>
        public static string GeneratePrefixFilter(string propertyName, string prefix)
        {
            char lastChar = prefix[prefix.Length - 1];
            char nextLastChar = (char)((int)lastChar + 1);
            string nextPrefix = prefix.Substring(0, prefix.Length - 1) + nextLastChar;

            return TableQuery.CombineFilters(
                TableQuery.GenerateFilterCondition(propertyName, "ge", prefix),
                TableOperators.And,
                TableQuery.GenerateFilterCondition(propertyName, "lt", nextPrefix)
            );
        }

        #region Select
        public static TableQuery<T> Select<T>(this TableQuery<T> tq, params string[] selectColumns) where T : ITableEntity, new()
        {
            return tq.Select((IList<string>)selectColumns);
        }
        #endregion
    }
}
