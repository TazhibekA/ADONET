
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace AutoLevelDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var providerName = ConfigurationManager.ConnectionStrings["ItemsConnectionString"].ProviderName;
            var connectionString = ConfigurationManager.ConnectionStrings["ItemsConnectionString"].ConnectionString;

            DbProviderFactory providerFactory = DbProviderFactories.GetFactory(providerName);

            DataSet itemsSet = new DataSet("itemsDb");

            DbDataAdapter dataAdapter = providerFactory.CreateDataAdapter();

            DbConnection connection = providerFactory.CreateConnection();
            connection.ConnectionString = connectionString;

            DbCommand selectCommand = providerFactory.CreateCommand();
            selectCommand.CommandText = "select * from Items";
            selectCommand.Connection = connection;

            dataAdapter.SelectCommand = selectCommand;


            DbCommandBuilder dbCommandBuilder = providerFactory.CreateCommandBuilder();
            dbCommandBuilder.DataAdapter = dataAdapter;
            dataAdapter.Fill(itemsSet,"Items");

            DataRow newRow = itemsSet.Tables["Items"].NewRow();
            newRow.BeginEdit();
            newRow.ItemArray = new object[] {4,"car",1212,123 };
            newRow.EndEdit();
            itemsSet.Tables["Items"].Rows.Add(newRow);

            dataAdapter.Update(itemsSet, "Items");
        }
    }
}
