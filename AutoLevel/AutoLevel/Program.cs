using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AutoLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataSet = new DataSet("UserDatabase");

            DataTable peopleTable = new DataTable("people");
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

            DataRow firstRow = peopleTable.NewRow();
            firstRow.BeginEdit();
            firstRow.ItemArray = new object[] { 1, "В.В.Кирсанов", 42 };
            firstRow.EndEdit();
            peopleTable.Rows.Add(firstRow);

            dataSet.Tables.Add(peopleTable);
            DataTable usersTable = new DataTable("users");
            //такие же действия как и для таблицы people

            DataRelation dataRelation = new DataRelation("users_people_fk","people","users",new string[] {"Id" }, new string[] { "personId" },false);

            dataSet.Relations.Add(dataRelation);
        }
    }
}
