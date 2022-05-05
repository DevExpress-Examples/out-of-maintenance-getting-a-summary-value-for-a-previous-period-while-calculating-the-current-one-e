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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim FieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo5 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo6 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo7 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo8 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo9 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo10 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo11 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo12 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim ExcelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            Dim ExcelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(ExcelWorksheetSettings1)
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
            Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldPercent = New DevExpress.XtraPivotGrid.PivotGridField()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.DataSource = Me.excelDataSource1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName1, Me.fieldSalesPerson1, Me.fieldOrderDate1, Me.fieldQuantity1, Me.fieldQuarter, Me.fieldPercent})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(693, 404)
            Me.pivotGridControl1.TabIndex = 0
            '
            'excelDataSource1
            '
            Me.excelDataSource1.Name = "excelDataSource1"
            Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
            FieldInfo1.Name = "CategoryName"
            FieldInfo1.OriginalName = Nothing
            FieldInfo1.Type = GetType(String)
            FieldInfo2.Name = "Country"
            FieldInfo2.OriginalName = Nothing
            FieldInfo2.Type = GetType(String)
            FieldInfo3.Name = "FirstName"
            FieldInfo3.OriginalName = Nothing
            FieldInfo3.Type = GetType(String)
            FieldInfo4.Name = "LastName"
            FieldInfo4.OriginalName = Nothing
            FieldInfo4.Type = GetType(String)
            FieldInfo5.Name = "ProductName"
            FieldInfo5.OriginalName = Nothing
            FieldInfo5.Type = GetType(String)
            FieldInfo6.Name = "Sales Person"
            FieldInfo6.OriginalName = Nothing
            FieldInfo6.Type = GetType(String)
            FieldInfo7.Name = "OrderDate"
            FieldInfo7.OriginalName = Nothing
            FieldInfo7.Type = GetType(Date)
            FieldInfo8.Name = "OrderID"
            FieldInfo8.OriginalName = Nothing
            FieldInfo8.Type = GetType(Double)
            FieldInfo9.Name = "Quantity"
            FieldInfo9.OriginalName = Nothing
            FieldInfo9.Type = GetType(Double)
            FieldInfo10.Name = "Discount"
            FieldInfo10.OriginalName = Nothing
            FieldInfo10.Type = GetType(Double)
            FieldInfo11.Name = "Extended Price"
            FieldInfo11.OriginalName = Nothing
            FieldInfo11.Type = GetType(Double)
            FieldInfo12.Name = "UnitPrice"
            FieldInfo12.OriginalName = Nothing
            FieldInfo12.Type = GetType(Double)
            Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {FieldInfo1, FieldInfo2, FieldInfo3, FieldInfo4, FieldInfo5, FieldInfo6, FieldInfo7, FieldInfo8, FieldInfo9, FieldInfo10, FieldInfo11, FieldInfo12})
            ExcelWorksheetSettings1.CellRange = Nothing
            ExcelWorksheetSettings1.WorksheetIndex = Nothing
            ExcelWorksheetSettings1.WorksheetName = "Data"
            ExcelSourceOptions1.ImportSettings = ExcelWorksheetSettings1
            Me.excelDataSource1.SourceOptions = ExcelSourceOptions1
            '
            'fieldProductName1
            '
            Me.fieldProductName1.AreaIndex = 0
            Me.fieldProductName1.Caption = "Product Name"
            DataSourceColumnBinding1.ColumnName = "ProductName"
            Me.fieldProductName1.DataBinding = DataSourceColumnBinding1
            Me.fieldProductName1.Name = "fieldProductName1"
            '
            'fieldSalesPerson1
            '
            Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPerson1.AreaIndex = 0
            Me.fieldSalesPerson1.Caption = "Sales Person"
            DataSourceColumnBinding2.ColumnName = "Sales Person"
            Me.fieldSalesPerson1.DataBinding = DataSourceColumnBinding2
            Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
            '
            'fieldOrderDate1
            '
            Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate1.AreaIndex = 0
            Me.fieldOrderDate1.Caption = "Order Date"
            DataSourceColumnBinding3.ColumnName = "OrderDate"
            DataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderDate1.DataBinding = DataSourceColumnBinding3
            Me.fieldOrderDate1.Name = "fieldOrderDate1"
            '
            'fieldQuantity1
            '
            Me.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity1.AreaIndex = 0
            Me.fieldQuantity1.Caption = "Quantity"
            DataSourceColumnBinding4.ColumnName = "Quantity"
            Me.fieldQuantity1.DataBinding = DataSourceColumnBinding4
            Me.fieldQuantity1.Name = "fieldQuantity1"
            Me.fieldQuantity1.Options.ShowGrandTotal = False
            '
            'fieldQuarter
            '
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldQuarter.AreaIndex = 1
            Me.fieldQuarter.Caption = "Quarter"
            DataSourceColumnBinding5.ColumnName = "OrderDate"
            DataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldQuarter.DataBinding = DataSourceColumnBinding5
            Me.fieldQuarter.Name = "fieldQuarter"
            '
            'fieldPercent
            '
            Me.fieldPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldPercent.AreaIndex = 1
            Me.fieldPercent.Caption = "Diff"
            DataSourceColumnBinding6.ColumnName = "Quantity"
            Me.fieldPercent.DataBinding = DataSourceColumnBinding6
            Me.fieldPercent.Name = "fieldPercent"
            Me.fieldPercent.Options.ShowGrandTotal = False
            Me.fieldPercent.Options.ShowTotals = False
            Me.fieldPercent.ToolTips.HeaderText = "Percent Difference from Previous Period"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(693, 404)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Percent Difference from Previous Period"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldPercent As DevExpress.XtraPivotGrid.PivotGridField
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
	End Class
End Namespace

