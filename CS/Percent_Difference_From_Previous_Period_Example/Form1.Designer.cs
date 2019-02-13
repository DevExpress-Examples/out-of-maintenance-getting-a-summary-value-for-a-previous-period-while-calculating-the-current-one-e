namespace WindowsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.customerReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new Percent_Difference_From_Previous_Period_Example.nwindDataSet();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCompanyName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.customerReportsTableAdapter = new Percent_Difference_From_Previous_Period_Example.nwindDataSetTableAdapters.CustomerReportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.customerReportsBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName,
            this.fieldCompanyName,
            this.fieldOrderDate,
            this.fieldProductAmount,
            this.fieldQuarter,
            this.fieldPercent});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(685, 404);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // customerReportsBindingSource
            // 
            this.customerReportsBindingSource.DataMember = "CustomerReports";
            this.customerReportsBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldProductName
            // 
            this.fieldProductName.AreaIndex = 0;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldCompanyName
            // 
            this.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCompanyName.AreaIndex = 0;
            this.fieldCompanyName.Caption = "Company Name";
            this.fieldCompanyName.FieldName = "CompanyName";
            this.fieldCompanyName.Name = "fieldCompanyName";
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate.AreaIndex = 0;
            this.fieldOrderDate.Caption = "Order Date";
            this.fieldOrderDate.FieldName = "OrderDate";
            this.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderDate.Name = "fieldOrderDate";
            this.fieldOrderDate.UnboundFieldName = "fieldOrderDate";
            // 
            // fieldProductAmount
            // 
            this.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductAmount.AreaIndex = 0;
            this.fieldProductAmount.Caption = "Product Amount";
            this.fieldProductAmount.FieldName = "ProductAmount";
            this.fieldProductAmount.Name = "fieldProductAmount";
            this.fieldProductAmount.Options.ShowGrandTotal = false;
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Quarter";
            this.fieldQuarter.FieldName = "OrderDate";
            this.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.UnboundFieldName = "fieldQuarter";
            // 
            // fieldPercent
            // 
            this.fieldPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPercent.AreaIndex = 1;
            this.fieldPercent.Caption = "Diff";
            this.fieldPercent.FieldName = "ProductAmount";
            this.fieldPercent.Name = "fieldPercent";
            this.fieldPercent.Options.ShowGrandTotal = false;
            this.fieldPercent.Options.ShowTotals = false;
            this.fieldPercent.ToolTips.HeaderText = "Percent Difference from Previous Period";
            // 
            // customerReportsTableAdapter
            // 
            this.customerReportsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 404);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Percent Difference from Previous Period";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource customerReportsBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCompanyName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductAmount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPercent;
        private Percent_Difference_From_Previous_Period_Example.nwindDataSet nwindDataSet;
        private Percent_Difference_From_Previous_Period_Example.nwindDataSetTableAdapters.CustomerReportsTableAdapter customerReportsTableAdapter;
    }
}

