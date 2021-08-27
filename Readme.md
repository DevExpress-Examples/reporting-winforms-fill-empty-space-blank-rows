<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602399/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3740)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/WindowsFormsApplication1/Data.cs) (VB: [Data.vb](./VB/WindowsFormsApplication1/Data.vb))
* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
* [XtraReport1.cs](./CS/WindowsFormsApplication1/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsFormsApplication1/XtraReport1.vb))
<!-- default file list end -->
# How to print DetailBand multiple times regardless of the number of records


<p>Sometimes, it is necessary to print a detail section a particular number of times even if the underlying DataSource contains a less number of records. The current version of XtraReports does not allow one to print this section more times than the number of records.</p>
<p>As a solution for this task, you can clear the report's <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_DataSourcetopic"><u>DataSource</u></a> and <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_DataMembertopic"><u>DataMember</u></a> properties, set the DetailPrintCountOnEmptyDataSource property to the necessary number, and then populate the detail section data manually using the DetailBand's <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_BeforePrinttopic"><u>BeforePrint</u></a> event.</p>
<p>This example demonstrates this approach in action.</p>
<p><strong>See also:<br><a href="https://www.devexpress.com/Support/Center/p/T210911">How to repeat the Detail report band multiple times (a data-bound report)</a></strong></p>

<br/>


