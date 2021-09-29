using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hakediş
{
   public static class DataTableColumnNameChange
    {
        public static void ChangeDataGridHeader(DataGridView dataGrid,string name1, string name2, string name3, string name4, string name5,string name6)
        {
            dataGrid.Columns[1].HeaderText = name1;
            dataGrid.Columns[2].HeaderText = name2;
            dataGrid.Columns[3].HeaderText = name3;
            dataGrid.Columns[4].HeaderText = name4;
            dataGrid.Columns[5].HeaderText = name5;
            dataGrid.Columns[6].HeaderText = name6;
        }
        public static void ChangeDataGridHeader(DataGridView dataGrid, string name1, string name2, string name3)
        {
            dataGrid.Columns[1].HeaderText = name1;
            dataGrid.Columns[2].HeaderText = name2;
            dataGrid.Columns[3].HeaderText = name3;
        }
    }
}
