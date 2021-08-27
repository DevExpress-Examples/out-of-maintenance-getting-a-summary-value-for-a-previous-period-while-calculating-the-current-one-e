<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2125)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication3/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication3/Form1.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
<!-- default file list end -->
# Getting a summary value for a previous period while calculating the current one


<p>Let us assume that we want to calculate the difference between the current and previous periods of time, and you want to allow end users to customize the resulting layout as they wish.</p>
<p>In this case, you should use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellValuetopic"><u>PivotGridControl.CustomCellValue</u></a> (<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellDisplayTexttopic"><u>PivotGridControl.CustomCellDisplayText</u></a>) event to calculate cell values. To access summary values for the previous period, you should create arrays of current row and column values, find a value that corresponds to the current period, and replace it with the one that corresponds to the previous period and call the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfPivotGridPivotCellBaseEventArgs_GetCellValuetopic.aspx">PivotCellBaseEventArgs.GetCellValue</a> method. You can access all field values via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridFieldBase_GetUniqueValuestopic"><u>PivotGridFieldBase.GetUniqueValues</u></a> method.</p>
<p><strong>See Also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/E1110">E1110: How to access other cell value while calculating the current cell</a></p>

<br/>


