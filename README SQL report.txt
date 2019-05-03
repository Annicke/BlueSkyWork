		
		
			SQL Report.

SQL stands for Structured Query Language , and it is used to communicate with the Database. This is a standard language used to perform tasks such as retrieval, updation, insertion and deletion of data from a database.

 What is a query?

A DataBase query is a code written in order to get the information back from the database. Query can be designed in such a way that it matched with our expectation of the result set. Simply, a question to the Database.

	SQL Statements.

Most of the actions you need to perform on a database are done with SQL statements.

	Some of The Most Important SQL Commands with their synthax

SELECT - extracts data from a database
	SELECT * FROM table_name;

UPDATE - updates data in a database
	UPDATE 'table_name' SET 'column_name' = 'new_value' [WHERE condition];
	UPDATE 'table_name' is the command that tells MySQL to update the data in a table.
	SET 'column_name' = 'new_value' are the names and values of the fields to be affected by the update query.

INSERT INTO - inserts new data into a database

	INSERT INTO 'table_name'(column_1,column_2,...) 
	VALUES (value_1,value_2,...);
N:B Changing the order of the columns has no effect on the INSERT query as long as the correct values have been mapped to the correct columns.

CREATE DATABASE - creates a new database
	CREATE TABLE tableName
	( 
 	 column_1 datatype [ NULL | NOT NULL ],
 	 column_2 datatype [ NULL | NOT NULL ],
  	...
	);

ALTER DATABASE - modifies a database
	There are two ways to Alter Table in SQL server.
	* Alter Table by adding new columns.
		1- Alter TABLE <Table name> ADD Column1 datatype, Column2 datatype;

	*Using Table designer
		2-Right Click on the existing Table>Design.
		3-Add Column Name and select Datatype.

DROP TABLE - DELETE a table

There are two ways to Delete Table in SQL server.

	* Using SQL Server Management Studio.
		1.Right Click on existing Table>Delete.
		2. On 'Delete Object' window, Click OK.
	*T-SQL: Delete Table
		1.Using the syntax Drop :DROP TABLE <tableName>; by clicking on execute.
		2.Table got deleted from the Table list.

N.B: Delete table only deletes all the rows, but the table structure still exists. We can again insert new rows.
The drop will permanently delete the Table structure, and hence we cannot insert new rows.
		

CREATE INDEX - creates an index (search key)
DROP INDEX - deletes an index

WHERE condition is optional, it can be used to specify criteria in the result set returned from the query.

	SELECT * FROM tableName WHERE condition;
The WHERE clause can be used in conjunction with logical operators such as AND and OR, comparison operators such as ,= 

When used with the AND logical operator, all the criteria must be met.
When used with the OR logical operator, any of the criteria must be met.
The key word IN is used to select rows matching a list of values.

		 WHAT IS JOINS?

This is a keyword used to query data from more tables based on the relationship between the fields of the tables. Keys play a major role when JOINs are used.

	The different types of join we have in SQL

There are various types of join which can be used to retrieve data and it depends on the relationship between tables.

Inner Join/Simple Join.
Inner join return rows when there is at least one match of rows between the tables.
		SELECT columns
		FROM table_1 
		INNER JOIN table_2
		ON table_1.column = table_2.column;

Right Join/Right Outer Join.
Right join return rows which are common between the tables and all rows of Right hand side table. Simply, it returns all the rows from the right hand side table even though there are no matches in the left hand side table.
		SELECT columns
		FROM table_1 
		RIGHT JOIN table_2
		ON table_1.column = table_2.column;

Left Join/Left Outer Join.
Left join return rows which are common between the tables and all rows of Left hand side table. Simply, it returns all the rows from Left hand side table even though there are no matches in the Right hand side table.

		SELECT columns
		FROM table_1 
		LEFT JOIN table_2
		ON table_1.column = table_2.column;

Full Join/Full Outer Join.
Full join return rows when there are matching rows in any one of the tables. This means, it returns all the rows from the left hand side table and all the rows from the right hand side table.

		SELECT columns
		FROM table_1 
		FULL JOIN table_2
		ON table_1.column = table_2.column;

What is CLAUSE?

SQL clause is defined to limit the result set by providing condition to the query. This usually filters some rows from the whole set of records.

Example – Query that has WHERE condition

Query that has HAVING condition.


	How to select unique records from a table

Select unique records from a table by using DISTINCT keyword.


















