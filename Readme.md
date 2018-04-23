# How to print DetailBand multiple times regardless of the number of records


<p>Sometimes, it is necessary to print a detail section a particular number of times even if the underlying DataSource contains a less number of records. The current version of XtraReports does not allow one to print this section more times than the number of records.</p>
<p>As a solution for this task, you can clear the report's <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_DataSourcetopic"><u>DataSource</u></a> and <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_DataMembertopic"><u>DataMember</u></a> properties, set the DetailPrintCountOnEmptyDataSource property to the necessary number, and then populate the detail section data manually using the DetailBand's <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_BeforePrinttopic"><u>BeforePrint</u></a> event.</p>
<p>This example demonstrates this approach in action.</p>
<p><strong>See also:<br><a href="https://www.devexpress.com/Support/Center/p/T210911">How to repeat the Detail report band multiple times (a data-bound report)</a></strong></p>

<br/>


