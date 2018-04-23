using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WindowsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Object> yearValues;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.CustomerReports' table. You can move, or remove it, as needed.
            this.customerReportsTableAdapter.Fill(this.nwindDataSet.CustomerReports);
        }

        private void pivotGridControl1_CustomCellDisplayText(object sender, DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs e)
        {
            PivotGridControl pivot = sender as PivotGridControl;
            if (e.DataField == fieldPercent)
            {
                List<object> rowValues = new List<object>();
                foreach (PivotGridField field in e.GetRowFields())
                    rowValues.Add(UpdateValue(field, e.RowIndex, e));
                List<object> columnValues = new List<object>();
                foreach (PivotGridField field in e.GetColumnFields())
                    columnValues.Add(UpdateValue(field, e.ColumnIndex, e));
                object previousValue = e.GetCellValue(columnValues.ToArray(), rowValues.ToArray(), e.DataField);
                if (previousValue == null)
                    e.DisplayText = string.Empty;
                else if (Convert.ToDecimal(previousValue) == 0)
                    e.DisplayText = "err";
                else                    
                    e.DisplayText = (Convert.ToDecimal(e.Value) / Convert.ToDecimal(previousValue) - 1).ToString("P");
            }

        }

        private List<Object> YearValues
        {
            get
            {
                if (yearValues == null)
                {

                    yearValues = new List<object>();
                    foreach (Object val in fieldOrderDate.GetUniqueValues())
                        yearValues.Add(val);
                    yearValues.Sort();
                }

                return yearValues;
            }
        }

        private object UpdateValue(PivotGridField field, int index, PivotCellDisplayTextEventArgs e)
        {
            Object value = e.GetFieldValue(field, index);
            if (field == fieldOrderDate)
            {
                int currentPosition = YearValues.IndexOf(value);
                if (currentPosition > 0)
                    value = YearValues[currentPosition - 1];
                else
                    value = "0000";
            }
            return value;
        }
    }
}