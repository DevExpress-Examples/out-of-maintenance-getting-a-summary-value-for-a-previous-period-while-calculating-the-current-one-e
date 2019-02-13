Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections.Generic

Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler pivotGridControl1.CustomCellDisplayText, AddressOf pivotGridControl1_CustomCellDisplayText
		End Sub

'INSTANT VB NOTE: The variable yearValues was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private yearValues_Renamed As List(Of Object)

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			excelDataSource1.FileName = "SalesPerson.xlsx"
			excelDataSource1.Fill()
			pivotGridControl1.BestFit()
			pivotGridControl1.BestFitDataHeaders(True)
			pivotGridControl1.CollapseAllColumns()
		End Sub

		Private Sub pivotGridControl1_CustomCellDisplayText(ByVal sender As Object, ByVal e As PivotCellDisplayTextEventArgs)
			Dim pivot As PivotGridControl = TryCast(sender, PivotGridControl)
			If e.DataField Is fieldPercent Then
				Dim rowValues As New List(Of Object)()
				For Each field As PivotGridField In e.GetRowFields()
					rowValues.Add(UpdateValue(field, e.RowIndex, e))
				Next field
				Dim columnValues As New List(Of Object)()
				For Each field As PivotGridField In e.GetColumnFields()
					columnValues.Add(UpdateValue(field, e.ColumnIndex, e))
				Next field
				Dim previousValue As Object = e.GetCellValue(columnValues.ToArray(), rowValues.ToArray(), e.DataField)
				If previousValue Is Nothing Then
					e.DisplayText = String.Empty
				ElseIf Convert.ToDecimal(previousValue) = 0 Then
					e.DisplayText = "err"
				Else
					e.DisplayText = (Convert.ToDecimal(e.Value) / Convert.ToDecimal(previousValue) - 1).ToString("P")
				End If
			End If

		End Sub

		Private ReadOnly Property YearValues() As List(Of Object)
			Get
				If yearValues_Renamed Is Nothing Then

					yearValues_Renamed = New List(Of Object)()
					For Each val As Object In fieldOrderDate.GetUniqueValues()
						yearValues_Renamed.Add(val)
					Next val
					yearValues_Renamed.Sort()
				End If

				Return yearValues_Renamed
			End Get
		End Property

		Private Function UpdateValue(ByVal field As PivotGridField, ByVal index As Integer, ByVal e As PivotCellDisplayTextEventArgs) As Object
			Dim value As Object = e.GetFieldValue(field, index)
			If field Is fieldOrderDate Then
				Dim currentPosition As Integer = YearValues.IndexOf(value)
				If currentPosition > 0 Then
					value = YearValues(currentPosition - 1)
				Else
					value = "0000"
				End If
			End If
			Return value
		End Function
	End Class
End Namespace