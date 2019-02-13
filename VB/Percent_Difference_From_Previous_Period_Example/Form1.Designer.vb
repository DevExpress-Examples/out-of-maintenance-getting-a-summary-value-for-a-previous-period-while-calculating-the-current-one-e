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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim fieldInfo1 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo2 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo3 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo4 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo5 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo6 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo7 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo8 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo9 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo10 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo11 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo12 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldPercent = New DevExpress.XtraPivotGrid.PivotGridField()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.excelDataSource1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProductName, Me.fieldSalesPerson, Me.fieldOrderDate, Me.fieldQuantity, Me.fieldQuarter, Me.fieldPercent})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(693, 404)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' excelDataSource1
			' 
			Me.excelDataSource1.Name = "excelDataSource1"
			Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
			fieldInfo1.Name = "CategoryName"
			fieldInfo1.Type = GetType(String)
			fieldInfo2.Name = "Country"
			fieldInfo2.Type = GetType(String)
			fieldInfo3.Name = "FirstName"
			fieldInfo3.Type = GetType(String)
			fieldInfo4.Name = "LastName"
			fieldInfo4.Type = GetType(String)
			fieldInfo5.Name = "ProductName"
			fieldInfo5.Type = GetType(String)
			fieldInfo6.Name = "Sales Person"
			fieldInfo6.Type = GetType(String)
			fieldInfo7.Name = "OrderDate"
			fieldInfo7.Type = GetType(Date)
			fieldInfo8.Name = "OrderID"
			fieldInfo8.Type = GetType(Double)
			fieldInfo9.Name = "Quantity"
			fieldInfo9.Type = GetType(Double)
			fieldInfo10.Name = "Discount"
			fieldInfo10.Type = GetType(Double)
			fieldInfo11.Name = "Extended Price"
			fieldInfo11.Type = GetType(Double)
			fieldInfo12.Name = "UnitPrice"
			fieldInfo12.Type = GetType(Double)
			Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9, fieldInfo10, fieldInfo11, fieldInfo12})
			excelWorksheetSettings1.CellRange = Nothing
			excelWorksheetSettings1.WorksheetName = "Data"
			excelSourceOptions1.ImportSettings = excelWorksheetSettings1
			Me.excelDataSource1.SourceOptions = excelSourceOptions1
			' 
			' fieldProductName
			' 
			Me.fieldProductName.AreaIndex = 0
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
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
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 0
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			Me.fieldQuantity.Options.ShowGrandTotal = False
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
			Me.fieldPercent.FieldName = "Quantity"
			Me.fieldPercent.Name = "fieldPercent"
			Me.fieldPercent.Options.ShowGrandTotal = False
			Me.fieldPercent.Options.ShowTotals = False
			Me.fieldPercent.ToolTips.HeaderText = "Percent Difference from Previous Period"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(693, 404)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Percent Difference from Previous Period"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldPercent As DevExpress.XtraPivotGrid.PivotGridField
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
	End Class
End Namespace

