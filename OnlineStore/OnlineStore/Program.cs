using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OnlineStore
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataSet = new DataSet("OnlineStore");

            DataTable categoryTable = new DataTable("Categories");
            DataColumn categoryIdColumn = new DataColumn("id");
            categoryIdColumn.DataType = typeof(int);
            categoryIdColumn.Unique = true;
            categoryIdColumn.AllowDBNull = false;
            categoryIdColumn.AutoIncrement = true;
            categoryIdColumn.AutoIncrementSeed = 1;
            categoryIdColumn.AutoIncrementStep = 1;
            categoryTable.Columns.Add(categoryIdColumn);
            DataColumn categoryNameColumn = new DataColumn("name");
            categoryNameColumn.DataType = typeof(string);
            categoryNameColumn.AllowDBNull = false;
            categoryTable.Columns.Add(categoryNameColumn);


            DataTable manufacturerTable = new DataTable("Manufacturers");
            DataColumn manufacturerIdColumn = new DataColumn("id");
            manufacturerIdColumn.DataType = typeof(int);
            manufacturerIdColumn.Unique = true;
            manufacturerIdColumn.AllowDBNull = false;
            manufacturerIdColumn.AutoIncrement = true;
            manufacturerIdColumn.AutoIncrementSeed = 1;
            manufacturerIdColumn.AutoIncrementStep = 1;
            manufacturerTable.Columns.Add(manufacturerIdColumn);
            DataColumn manufacturerNameColumn = new DataColumn("name");
            manufacturerNameColumn.DataType = typeof(string);
            manufacturerNameColumn.AllowDBNull = false;
            manufacturerTable.Columns.Add(manufacturerNameColumn);


            DataTable goodTable = new DataTable("Goods");
            DataColumn goodIdColumn = new DataColumn("id");
            goodIdColumn.DataType = typeof(int);
            goodIdColumn.Unique = true;
            goodIdColumn.AllowDBNull = false;
            goodIdColumn.AutoIncrement = true;
            goodIdColumn.AutoIncrementSeed = 1;
            goodIdColumn.AutoIncrementStep = 1;
            goodTable.Columns.Add(goodIdColumn);
            DataColumn goodNameColumn = new DataColumn("name");
            goodNameColumn.DataType = typeof(string);
            goodNameColumn.AllowDBNull = false;
            goodTable.Columns.Add(goodNameColumn);
            DataColumn goodManufactureIdColumn = new DataColumn("manufacture_id");
            goodManufactureIdColumn.DataType = typeof(int); 
            goodManufactureIdColumn.AllowDBNull = false; 
            goodTable.Columns.Add(goodManufactureIdColumn);
            DataColumn goodCostColumn = new DataColumn("cost");
            goodCostColumn.DataType = typeof(int); 
            goodCostColumn.AllowDBNull = false;
            goodTable.Columns.Add(goodCostColumn);

            DataTable orderTable = new DataTable("Orders");
            DataColumn orderIdColumn = new DataColumn("id");
            orderIdColumn.DataType = typeof(int);
            orderIdColumn.Unique = true;
            orderIdColumn.AllowDBNull = false;
            orderIdColumn.AutoIncrement = true;
            orderIdColumn.AutoIncrementSeed = 1;
            orderIdColumn.AutoIncrementStep = 1;
            orderTable.Columns.Add(orderIdColumn);
            DataColumn orderGoodIdColumn = new DataColumn("good_id");
            orderGoodIdColumn.DataType = typeof(int);
            orderGoodIdColumn.AllowDBNull = false;
            orderTable.Columns.Add(orderGoodIdColumn);
            DataColumn orderDateTimeColumn = new DataColumn("date and time");
            orderDateTimeColumn.DataType = typeof(DateTime);
            orderDateTimeColumn.AllowDBNull = false;
            orderTable.Columns.Add(orderDateTimeColumn);












        }
    }
}
