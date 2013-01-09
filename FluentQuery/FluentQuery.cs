using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace SepiaLabs.AzureTools
{
    public class FluentQuery
    {
        private FluentQuery()
        {
        }

        public static FluentQueryInstance New()
        {
            return new FluentQueryInstance();
        }

        #region Where
        public static FluentQueryInstance Where(string propertyName, string op, string value)
        {
            return (new FluentQueryInstance()).Where(TableQuery.GenerateFilterCondition(propertyName, op, value));
        }

        public static FluentQueryInstance Where(string propertyName, string op, byte[] value)
        {
            return (new FluentQueryInstance()).Where(TableQuery.GenerateFilterConditionForBinary(propertyName, op, value));
        }

        public static FluentQueryInstance Where(string propertyName, string op, bool value)
        {
            return (new FluentQueryInstance()).Where(TableQuery.GenerateFilterConditionForBool(propertyName, op, value));
        }

        public static FluentQueryInstance Where(string propertyName, string op, DateTimeOffset value)
        {
            return (new FluentQueryInstance()).Where(TableQuery.GenerateFilterConditionForDate(propertyName, op, value));
        }

        public static FluentQueryInstance Where(string propertyName, string op, double value)
        {
            return (new FluentQueryInstance()).Where(TableQuery.GenerateFilterConditionForDouble(propertyName, op, value));
        }

        public static FluentQueryInstance Where(string propertyName, string op, Guid value)
        {
            return (new FluentQueryInstance()).Where(TableQuery.GenerateFilterConditionForGuid(propertyName, op, value));
        }

        public static FluentQueryInstance Where(string propertyName, string op, int value)
        {
            return (new FluentQueryInstance()).Where(TableQuery.GenerateFilterConditionForInt(propertyName, op, value));
        }

        public static FluentQueryInstance Where(string propertyName, string op, long value)
        {
            return (new FluentQueryInstance()).Where(TableQuery.GenerateFilterConditionForLong(propertyName, op, value));
        }

        public static FluentQueryInstance Where(string filter)
        {
            return (new FluentQueryInstance()).Where(filter);
        }
        #endregion

        #region And
        public static FluentQueryInstance And(string propertyName, string op, string value)
        {
            return (new FluentQueryInstance()).And(TableQuery.GenerateFilterCondition(propertyName, op, value));
        }

        public static FluentQueryInstance And(string propertyName, string op, byte[] value)
        {
            return (new FluentQueryInstance()).And(TableQuery.GenerateFilterConditionForBinary(propertyName, op, value));
        }

        public static FluentQueryInstance And(string propertyName, string op, bool value)
        {
            return (new FluentQueryInstance()).And(TableQuery.GenerateFilterConditionForBool(propertyName, op, value));
        }

        public static FluentQueryInstance And(string propertyName, string op, DateTimeOffset value)
        {
            return (new FluentQueryInstance()).And(TableQuery.GenerateFilterConditionForDate(propertyName, op, value));
        }

        public static FluentQueryInstance And(string propertyName, string op, double value)
        {
            return (new FluentQueryInstance()).And(TableQuery.GenerateFilterConditionForDouble(propertyName, op, value));
        }

        public static FluentQueryInstance And(string propertyName, string op, Guid value)
        {
            return (new FluentQueryInstance()).And(TableQuery.GenerateFilterConditionForGuid(propertyName, op, value));
        }

        public static FluentQueryInstance And(string propertyName, string op, int value)
        {
            return (new FluentQueryInstance()).And(TableQuery.GenerateFilterConditionForInt(propertyName, op, value));
        }

        public static FluentQueryInstance And(string propertyName, string op, long value)
        {
            return (new FluentQueryInstance()).And(TableQuery.GenerateFilterConditionForLong(propertyName, op, value));
        }

        public static FluentQueryInstance And(string filter)
        {
            return (new FluentQueryInstance()).And(filter);
        }
        #endregion

        #region Or
        public static FluentQueryInstance Or(string propertyName, string op, string value)
        {
            return (new FluentQueryInstance()).Or(TableQuery.GenerateFilterCondition(propertyName, op, value));
        }

        public static FluentQueryInstance Or(string propertyName, string op, byte[] value)
        {
            return (new FluentQueryInstance()).Or(TableQuery.GenerateFilterConditionForBinary(propertyName, op, value));
        }

        public static FluentQueryInstance Or(string propertyName, string op, bool value)
        {
            return (new FluentQueryInstance()).Or(TableQuery.GenerateFilterConditionForBool(propertyName, op, value));
        }

        public static FluentQueryInstance Or(string propertyName, string op, DateTimeOffset value)
        {
            return (new FluentQueryInstance()).Or(TableQuery.GenerateFilterConditionForDate(propertyName, op, value));
        }

        public static FluentQueryInstance Or(string propertyName, string op, double value)
        {
            return (new FluentQueryInstance()).Or(TableQuery.GenerateFilterConditionForDouble(propertyName, op, value));
        }

        public static FluentQueryInstance Or(string propertyName, string op, Guid value)
        {
            return (new FluentQueryInstance()).Or(TableQuery.GenerateFilterConditionForGuid(propertyName, op, value));
        }

        public static FluentQueryInstance Or(string propertyName, string op, int value)
        {
            return (new FluentQueryInstance()).Or(TableQuery.GenerateFilterConditionForInt(propertyName, op, value));
        }

        public static FluentQueryInstance Or(string propertyName, string op, long value)
        {
            return (new FluentQueryInstance()).Or(TableQuery.GenerateFilterConditionForLong(propertyName, op, value));
        }

        public static FluentQueryInstance Or(string filter)
        {
            return (new FluentQueryInstance()).Or(filter);
        }
        #endregion

        #region Not
        public static FluentQueryInstance Not(string propertyName, string op, string value)
        {
            return (new FluentQueryInstance()).Not(TableQuery.GenerateFilterCondition(propertyName, op, value));
        }

        public static FluentQueryInstance Not(string propertyName, string op, byte[] value)
        {
            return (new FluentQueryInstance()).Not(TableQuery.GenerateFilterConditionForBinary(propertyName, op, value));
        }

        public static FluentQueryInstance Not(string propertyName, string op, bool value)
        {
            return (new FluentQueryInstance()).Not(TableQuery.GenerateFilterConditionForBool(propertyName, op, value));
        }

        public static FluentQueryInstance Not(string propertyName, string op, DateTimeOffset value)
        {
            return (new FluentQueryInstance()).Not(TableQuery.GenerateFilterConditionForDate(propertyName, op, value));
        }

        public static FluentQueryInstance Not(string propertyName, string op, double value)
        {
            return (new FluentQueryInstance()).Not(TableQuery.GenerateFilterConditionForDouble(propertyName, op, value));
        }

        public static FluentQueryInstance Not(string propertyName, string op, Guid value)
        {
            return (new FluentQueryInstance()).Not(TableQuery.GenerateFilterConditionForGuid(propertyName, op, value));
        }

        public static FluentQueryInstance Not(string propertyName, string op, int value)
        {
            return (new FluentQueryInstance()).Not(TableQuery.GenerateFilterConditionForInt(propertyName, op, value));
        }

        public static FluentQueryInstance Not(string propertyName, string op, long value)
        {
            return (new FluentQueryInstance()).Not(TableQuery.GenerateFilterConditionForLong(propertyName, op, value));
        }

        public static FluentQueryInstance NotHasPrefix(string propertyName, string prefix)
        {
            return (new FluentQueryInstance()).NotHasPrefix(propertyName, prefix);
        }

        public static FluentQueryInstance Not(string filter)
        {
            return (new FluentQueryInstance()).Not(filter);
        }
        #endregion

        public FluentQueryInstance Take(int take)
        {
            return (new FluentQueryInstance()).Take(take);
        }

        public FluentQueryInstance Select(params string[] propertyNames)
        {
            return (new FluentQueryInstance()).Select(propertyNames);
        }
    }

    public class FluentQueryInstance
    {
        private string filter;
        private int? take;
        private List<string> select;

        internal FluentQueryInstance()
        {
            filter = null;
            take = null;
            select = null;
        }

        #region Where
        public FluentQueryInstance Where(string propertyName, string op, string value)
        {
            this.Where(TableQuery.GenerateFilterCondition(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Where(string propertyName, string op, byte[] value)
        {
            this.Where(TableQuery.GenerateFilterConditionForBinary(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Where(string propertyName, string op, bool value)
        {
            this.Where(TableQuery.GenerateFilterConditionForBool(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Where(string propertyName, string op, DateTimeOffset value)
        {
            this.Where(TableQuery.GenerateFilterConditionForDate(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Where(string propertyName, string op, double value)
        {
            this.Where(TableQuery.GenerateFilterConditionForDouble(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Where(string propertyName, string op, Guid value)
        {
            this.Where(TableQuery.GenerateFilterConditionForGuid(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Where(string propertyName, string op, int value)
        {
            this.Where(TableQuery.GenerateFilterConditionForInt(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Where(string propertyName, string op, long value)
        {
            this.Where(TableQuery.GenerateFilterConditionForLong(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance WhereHasPrefix(string propertyName, string prefix)
        {
            return this.Where(GeneratePrefixFilter(propertyName, prefix));
        }

        public FluentQueryInstance Where(string filterCondition)
        {
            if (!string.IsNullOrEmpty(filter))
            {
                throw new InvalidOperationException("Filter conditions after the first must be added using a logical operator");
            }

            filter = filterCondition;
            return this;
        }
        #endregion

        #region And
        public FluentQueryInstance And(string propertyName, string op, string value)
        {
            this.And(TableQuery.GenerateFilterCondition(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance And(string propertyName, string op, byte[] value)
        {
            this.And(TableQuery.GenerateFilterConditionForBinary(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance And(string propertyName, string op, bool value)
        {
            this.And(TableQuery.GenerateFilterConditionForBool(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance And(string propertyName, string op, DateTimeOffset value)
        {
            this.And(TableQuery.GenerateFilterConditionForDate(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance And(string propertyName, string op, double value)
        {
            this.And(TableQuery.GenerateFilterConditionForDouble(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance And(string propertyName, string op, Guid value)
        {
            this.And(TableQuery.GenerateFilterConditionForGuid(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance And(string propertyName, string op, int value)
        {
            this.And(TableQuery.GenerateFilterConditionForInt(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance And(string propertyName, string op, long value)
        {
            this.And(TableQuery.GenerateFilterConditionForLong(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance AndHasPrefix(string propertyName, string prefix)
        {
            return this.And(GeneratePrefixFilter(propertyName, prefix));
        }

        public FluentQueryInstance And(string filterCondition)
        {
            if (string.IsNullOrEmpty(this.filter))
            {
                this.Where(filterCondition);
            }
            else
            {
                filter = TableQuery.CombineFilters(filter, TableOperators.And, filterCondition);
            }

            return this;
        }
        #endregion

        #region Or
        public FluentQueryInstance Or(string propertyName, string op, string value)
        {
            this.Or(TableQuery.GenerateFilterCondition(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Or(string propertyName, string op, byte[] value)
        {
            this.Or(TableQuery.GenerateFilterConditionForBinary(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Or(string propertyName, string op, bool value)
        {
            this.Or(TableQuery.GenerateFilterConditionForBool(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Or(string propertyName, string op, DateTimeOffset value)
        {
            this.Or(TableQuery.GenerateFilterConditionForDate(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Or(string propertyName, string op, double value)
        {
            this.Or(TableQuery.GenerateFilterConditionForDouble(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Or(string propertyName, string op, Guid value)
        {
            this.Or(TableQuery.GenerateFilterConditionForGuid(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Or(string propertyName, string op, int value)
        {
            this.Or(TableQuery.GenerateFilterConditionForInt(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Or(string propertyName, string op, long value)
        {
            this.Or(TableQuery.GenerateFilterConditionForLong(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance OrHasPrefix(string propertyName, string prefix)
        {
            return this.Or(GeneratePrefixFilter(propertyName, prefix));
        }

        public FluentQueryInstance Or(string filterCondition)
        {
            if (string.IsNullOrEmpty(this.filter))
            {
                this.Where(filterCondition);
            }
            else
            {
                filter = TableQuery.CombineFilters(filter, TableOperators.Or, filterCondition);
            }

            return this;
        }
        #endregion

        #region Not
        public FluentQueryInstance Not(string propertyName, string op, string value)
        {
            this.Not(TableQuery.GenerateFilterCondition(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Not(string propertyName, string op, byte[] value)
        {
            this.Not(TableQuery.GenerateFilterConditionForBinary(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Not(string propertyName, string op, bool value)
        {
            this.Not(TableQuery.GenerateFilterConditionForBool(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Not(string propertyName, string op, DateTimeOffset value)
        {
            this.Not(TableQuery.GenerateFilterConditionForDate(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Not(string propertyName, string op, double value)
        {
            this.Not(TableQuery.GenerateFilterConditionForDouble(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Not(string propertyName, string op, Guid value)
        {
            this.Not(TableQuery.GenerateFilterConditionForGuid(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Not(string propertyName, string op, int value)
        {
            this.Not(TableQuery.GenerateFilterConditionForInt(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance Not(string propertyName, string op, long value)
        {
            this.Not(TableQuery.GenerateFilterConditionForLong(propertyName, op, value));
            return this;
        }

        public FluentQueryInstance NotHasPrefix(string propertyName, string prefix)
        {
            return this.Not(GeneratePrefixFilter(propertyName, prefix));
        }

        public FluentQueryInstance Not(string filterCondition)
        {
            if (!string.IsNullOrEmpty(this.filter))
            {
                throw new InvalidOperationException("Cannot use a 'Not' operator as the first filter");
            }
            else
            {
                filter = TableQuery.CombineFilters(filter, TableOperators.Not, filterCondition);
            }

            return this;
        }
        #endregion

        public FluentQueryInstance Take(int take)
        {
            this.take = take;
            return this;
        }

        public FluentQueryInstance Select(params string[] propertyNames)
        {
            if (this.select == null)
            {
                this.select = new List<string>(propertyNames);
            }
            else
            {
                this.select.AddRange(propertyNames);
            }
            return this;
        }

        public TableQuery ToQuery()
        {
            return new TableQuery()
            {
                FilterString = filter,
                SelectColumns = select,
                TakeCount = take
            };
        }

        public TableQuery<T> ToQuery<T>()
            where T : ITableEntity, new()
        {
            return new TableQuery<T>()
            {
                FilterString = filter,
                SelectColumns = select,
                TakeCount = take
            };
        }

        /// <summary>
        /// Apply an extra "where" condition to a query that will look for RowKeys with the specified prefix.
        /// Usage: (from r in myQuery where r.PartitionKey == "blah" select r).Where(RowKeyHasPrefix("myPrefix")).AsTableServiceQuery().ToList()
        /// </summary>
        public string GeneratePrefixFilter(string propertyName, string prefix)
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
    }
}
