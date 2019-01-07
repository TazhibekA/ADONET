using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LocalDBLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataSet = new DataSet("Library");

            

            DataTable peopleTable = new DataTable("students");
            DataColumn personIdColumn = new DataColumn("id");
            personIdColumn.DataType = typeof(int);
            personIdColumn.Unique = true;
            personIdColumn.AllowDBNull = false;
            personIdColumn.AutoIncrement = true;
            personIdColumn.AutoIncrementSeed = 1;
            personIdColumn.AutoIncrementStep = 1;
            peopleTable.Columns.Add(personIdColumn);

            DataColumn personFullNameColumn = new DataColumn("fullName");
            personFullNameColumn.DataType = typeof(string);
            peopleTable.Columns.Add(personFullNameColumn);

            DataColumn personAgeColumn = new DataColumn("age");
            personAgeColumn.DataType = typeof(int);
            peopleTable.Columns.Add(personAgeColumn);

            DataColumn personGenderColumn = new DataColumn("gender");
            personGenderColumn.DataType = typeof(string);
            peopleTable.Columns.Add(personGenderColumn);
             
            dataSet.Tables.Add(peopleTable);



            DataTable authorTable = new DataTable("authors");

            DataColumn authorIdColumn = new DataColumn("id");
            authorIdColumn.DataType = typeof(int);
            authorIdColumn.Unique = true;
            authorIdColumn.AllowDBNull = false;
            authorIdColumn.AutoIncrement = true;
            authorIdColumn.AutoIncrementSeed = 1;
            authorIdColumn.AutoIncrementStep = 1;
            authorTable.Columns.Add(personIdColumn);

            DataColumn authorFullNameColumn = new DataColumn("fullName");
            authorFullNameColumn.DataType = typeof(string);
            authorTable.Columns.Add(authorFullNameColumn);

            dataSet.Tables.Add(authorTable);





            DataTable bookTable = new DataTable("books");

            DataColumn bookIdColumn = new DataColumn("id");
            bookIdColumn.DataType = typeof(int);
            bookIdColumn.Unique = true;
            bookIdColumn.AllowDBNull = false;
            bookIdColumn.AutoIncrement = true;
            bookIdColumn.AutoIncrementSeed = 1;
            bookIdColumn.AutoIncrementStep = 1;
            authorTable.Columns.Add(bookIdColumn);

            DataColumn bookNameColumn = new DataColumn("name");
            bookNameColumn.DataType = typeof(string);
            bookTable.Columns.Add(bookNameColumn);


            DataColumn bookPageCountColumn = new DataColumn("pageCount");
            bookPageCountColumn.DataType = typeof(int);
            bookTable.Columns.Add(bookPageCountColumn);
 
            DataColumn bookAuthorIdColumn = new DataColumn("authorId");
            bookAuthorIdColumn.DataType = typeof(int);
            bookTable.Columns.Add(bookAuthorIdColumn);

            dataSet.Tables.Add(bookTable);



            DataTable borrowTable = new DataTable("borrows");

            DataColumn borrowIdColumn = new DataColumn("id");
            borrowIdColumn.DataType = typeof(int);
            borrowIdColumn.Unique = true;
            borrowIdColumn.AllowDBNull = false;
            borrowIdColumn.AutoIncrement = true;
            borrowIdColumn.AutoIncrementSeed = 1;
            borrowIdColumn.AutoIncrementStep = 1;
            borrowTable.Columns.Add(borrowIdColumn);

            


            DataColumn borrowBookIdColumn = new DataColumn("bookId");
            borrowBookIdColumn.DataType = typeof(int);
            borrowTable.Columns.Add(borrowBookIdColumn);

            DataColumn borrowStudentIdColumn = new DataColumn("studentId");
            borrowStudentIdColumn.DataType = typeof(int);
            borrowTable.Columns.Add(borrowStudentIdColumn);

            DataColumn borrowTakenDateColumn = new DataColumn("takenDate");
            borrowTakenDateColumn.DataType = typeof(DateTime);
            borrowTable.Columns.Add(borrowTakenDateColumn);

            DataColumn borrowBroughtnDateColumn = new DataColumn("broughtDate");
            borrowBroughtnDateColumn.DataType = typeof(DateTime);
            borrowTable.Columns.Add(borrowBroughtnDateColumn);

            dataSet.Tables.Add(borrowTable);




            DataRelation firstDataRelation = new DataRelation("users_people_fk", "students", "borrows", new string[] { "id" }, new string[] { "studentId" }, false);
            DataRelation secondDataRelation = new DataRelation("users_people_fk", "books", "borrows", new string[] { "id" }, new string[] { "bookId" }, false);
            DataRelation thirdDataRelation = new DataRelation("users_people_fk", "authors", "books", new string[] { "id" }, new string[] { "authorId" }, false);

            dataSet.Relations.Add(firstDataRelation);
            dataSet.Relations.Add(secondDataRelation);
            dataSet.Relations.Add(thirdDataRelation);


        }
    }
}
