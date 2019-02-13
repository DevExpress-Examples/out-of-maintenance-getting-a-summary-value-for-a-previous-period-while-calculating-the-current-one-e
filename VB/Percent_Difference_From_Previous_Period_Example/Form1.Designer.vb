Namespace WindowsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.customerReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Percent_Difference_From_Previous_Period_Example.nwindDataSet()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCompanyName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldPercent = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.customerReportsTableAdapter = New Percent_Difference_From_Previous_Period_Example.nwindDataSetTableAdapters.CustomerReportsTableAdapter()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.customerReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.customerReportsBindingSource
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProductName, Me.fieldCompanyName, Me.fieldOrderDate, Me.fieldProductAmount, Me.fieldQuarter, Me.fieldPercent})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(685, 404)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' customerReportsBindingSource
			' 
			Me.customerReportsBindingSource.DataMember = "CustomerReports"
			Me.customerReportsBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldProductName
			' 
			Me.fieldProductName.AreaIndex = 0
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldCompanyName
			' 
			Me.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCompanyName.AreaIndex = 0
			Me.fieldCompanyName.Caption = "Company Name"
			Me.fieldCompanyName.FieldName = "CompanyName"
			Me.fieldCompanyName.Name = "fieldCompanyName"
			' 
			' fieldOrderDate
			' 
			Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate.AreaIndex = 0
			Me.fieldOrderDate.Caption = "Order Date"
			Me.fieldOrderDate.FieldName = "OrderDate"
			Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderDate.Name = "fieldOrderDate"
			Me.fieldOrderDate.UnboundFieldName = "fieldOrderDate"
			' 
			' fieldProductAmount
			' 
			Me.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldProductAmount.AreaIndex = 0
			Me.fieldProductAmount.Caption = "Product Amount"
			Me.fieldProductAmount.FieldName = "ProductAmount"
			Me.fieldProductAmount.Name = "fieldProductAmount"
			Me.fieldProductAmount.Options.ShowGrandTotal = False
			' 
			' fieldQuarter
			' 
			Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldQuarter.AreaIndex = 1
			Me.fieldQuarter.Caption = "Quarter"
			Me.fieldQuarter.FieldName = "OrderDate"
			Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldQuarter.Name = "fieldQuarter"
			Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
			' 
			' fieldPercent
			' 
			Me.fieldPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldPercent.AreaIndex = 1
			Me.fieldPercent.Caption = "Diff"
			Me.fieldPercent.FieldName = "ProductAmount"
			Me.fieldPercent.Name = "fieldPercent"
			Me.fieldPercent.Options.ShowGrandTotal = False
			Me.fieldPercent.Options.ShowTotals = False
			Me.fieldPercent.ToolTips.HeaderText = "Percent Difference from Previous Period"
			' 
			' customerReportsTableAdapter
			' 
			Me.customerReportsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(685, 404)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Percent Difference from Previous Period"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.customerReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private customerReportsBindingSource As System.Windows.Forms.BindingSource
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCompanyName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductAmount As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldPercent As DevExpress.XtraPivotGrid.PivotGridField
		Private nwindDataSet As Percent_Difference_From_Previous_Period_Example.nwindDataSet
		Private customerReportsTableAdapter As Percent_Difference_From_Previous_Period_Example.nwindDataSetTableAdapters.CustomerReportsTableAdapter
	End Class
End Namespace

