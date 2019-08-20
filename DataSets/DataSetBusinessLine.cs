using System.Data;

namespace LinqQuery.DataSets
{
    public static class DataSetBusinessLine
    {
        public static DataSet Get(){
            var dataSet = new DataSet();
            var dataTable = new DataTable();

            dataTable.Columns.Add("ClientNumber");
            dataTable.Columns.Add("BusinessLineId");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("TierId");
            dataTable.Columns.Add("TierName");
            dataTable.Columns.Add("ProductId");
            dataTable.Columns.Add("ProductName");

            dataTable.Rows.Add(new object[] {"CLI-0000292","7","Pay TV","5","Premium","38","Fox Life"});
            dataTable.Rows.Add(new object[] {"CLI-0000292","7","Pay TV","5","Premium","41","Cinecanal"});
            dataTable.Rows.Add(new object[] {"CLI-0000292","7","Pay TV","2","Basic","48","NGW HD"});
            dataTable.Rows.Add(new object[] {"CLI-0000292","7","Pay TV","2","Basic","47","Nat Geo Wild"});
            dataTable.Rows.Add(new object[] {"CLI-0000292","7","Pay TV","1","Mini Basic","28","Nat Geo"});
            dataTable.Rows.Add(new object[] {"CLI-0000292","7","Pay TV","2","Basic","4","Utilisima"});
            dataTable.Rows.Add(new object[] {"CLI-0000292","7","Pay TV","5","Premium","27","Canal Fox"});
            dataTable.Rows.Add(new object[] {"CLI-0000292","7","Pay TV","7","V-MVPD Fox Sports Premium","30","Fox Sports"});

            dataSet.Tables.Add(dataTable);

            return dataSet;
        }
    }
}