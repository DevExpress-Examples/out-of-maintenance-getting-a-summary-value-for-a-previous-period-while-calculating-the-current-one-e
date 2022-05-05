using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;

namespace WindowsApplication3
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            pivotGridControl1.CustomCellDisplayText += pivotGridControl1_CustomCellDisplayText;
        }

        List<Object> yearValues;

        private void Form1_Load(object sender, EventArgs e)
        {
            excelDataSource1.FileName = "SalesPerson.xlsx";
            excelDataSource1.Fill();
            pivotGridControl1.BestFit();
            pivotGridControl1.BestFitDataHeaders(true);
            pivotGridControl1.CollapseAllColumns();
        }

        private void pivotGridControl1_CustomCellDisplayText(object sender, PivotCellDisplayTextEventArgs e)
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
                    foreach (Object val in fieldOrderDate1.GetUniqueValues())
                        yearValues.Add(val);
                    yearValues.Sort();
                }

                return yearValues;
            }
        }

        private object UpdateValue(PivotGridField field, int index, PivotCellDisplayTextEventArgs e)
        {
            Object value = e.GetFieldValue(field, index);
            if (field == fieldOrderDate1)
            {
                int currentPosition = YearValues.IndexOf(value);
                if (currentPosition > 0)
                    value = YearValues[currentPosition - 1];
                else
                    value = "0000";
            };
            return value;
        }
    }
}