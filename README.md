FluentQuery
===========

FluentQuery is a set of extension methods that provide a fluent API for querying Azure Table Storage.
FluentQuery supports the basic operations: ```Where```, ```And```, ```Or```, ```Not```, ```Take``` and ```Select```. 

There is no support for complex queries (eg, things you would need parentheses for). But it's generally not a good idea to run queries like that anyway, so it's not a big loss. 

Example
=======
Using the basic Azure Storage Client library you might write something like this.
```c#
using FluentQuery;

var filter = TableQuery.CombineFilters(
                TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equals, foo),
                TableOperators.And,
                TableQuery.GenerateFilterCondition("RowKey", QueryComparisons.Equals, bar)
            );
var myQuery = new TableQuery<FooBarEntity>().Where(filter);
```

That translates to this in FluentQuery
```c#
using FluentQuery;

var myQuery = new TableQuery<FooBarEntity>()
                .Where("PartitionKey", QueryComparisons.Equals, foo) //first condition needs to be a Where()
                .And("RowKey", QueryComparisons.Equals, bar) //subsequent conditions should use And() or Or()
                .Take(1)  //you can use Take() as well, though it is silly in this particular example
				.Select("baz"); //or Select
```

Prefix Queries
==============

FluentQuery also provides one utility method for querying an attribute by prefix, by querying for entities that are greater-or-equal to the prefix, and less-than (prefix + 1).

```c#
using FluentQuery;

string condition = FluentQueryExtensions.GeneratePrefixFilter("RowKey", "abcd");
//condition == "(RowKey ge 'abcd') and (RowKey lt 'abce')"

condition = = FluentQueryExtensions.GeneratePrefixFilter("RowKey", "ab-");
//condition = "(RowKey ge 'ab-') and (RowKey lt 'ab.')"
```

NuGet
=====

Get the package from [NuGet](https://nuget.org/packages/FluentQuery).