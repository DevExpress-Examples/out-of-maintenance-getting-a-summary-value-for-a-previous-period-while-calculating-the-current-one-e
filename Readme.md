<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579553/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2125)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication3/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication3/Form1.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
<!-- default file list end -->
# How to Display a Percent Difference from the Previous Parallel Period

This example demonstrates how to display the difference between the value for the current year (quarter) and the value for the previous year (the same quarter of the previous year).

![screenshot](https://github.com/DevExpress-Examples/getting-a-summary-value-for-a-previous-period-while-calculating-the-current-one-e2125/blob/13.1.4%2B/images/screenshot.png)

API in this example:

* [PivotGridControl.CustomCellDisplayText](http://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellDisplayText) event
* [PivotCellDisplayTextEventArgs.GetCellValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotCellBaseEventArgs.GetCellValue(System.Object---System.Object---DevExpress.Xpf.PivotGrid.PivotGridField)) method
* [PivotGridField.GetUniqueValues](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.GetUniqueValues.overloads) method

See also:

* [How to Access a Different Cell's Value While Calculating the Value of the Current Cell](https://github.com/DevExpress-Examples/how-to-access-other-cell-value-while-calculating-the-current-cell-e1110#how-to-access-other-cell-value-while-calculating-the-current-cell)
