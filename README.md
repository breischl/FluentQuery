FluentQuery
===========

FluentQuery is a fluent API for writing queries against Azure Table Storage using version 2 of the .NET library. FluentQuery supports the basic operations: ```Where```, ```And```, ```Or```, ```Not```, ```Take``` and ```Select```. 

There is no support for complex queries (eg, things you would need parentheses for). But it's generally not a good idea to run queries like that anyway, so it's not a big loss. 

Example
=======
```c#
var myQuery = FluentQuery
                .Where("PartitionKey", "eq", foo) //first condition needs to be a Where()
                .And("RowKey", "eq", bar) //subsequent conditions should use And() or Or()
                .Take(1)  //you can use Take() as well, though it is silly in this particular example
                .ToQuery<FooBarEntity>(); //Create a TableQuery<>

var results = myCloudTableReference.ExecuteQuery(myQuery);
```
