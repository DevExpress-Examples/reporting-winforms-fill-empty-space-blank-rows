<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/WindowsFormsApplication1/Data.cs) (VB: [Data.vb](./VB/WindowsFormsApplication1/Data.vb))
* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
* [XtraReport1.cs](./CS/WindowsFormsApplication1/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsFormsApplication1/XtraReport1.vb))
<!-- default file list end -->
# How to add blank rows and fill the empty space between the Detail band and the next band or the end of the page

In the v19.2 release, we supported this scenario and introduced the [DetailBand.FillEmptySpace](%C2%A0%5Bhttps://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.DetailBand.FillEmptySpace%5D%5B1%5D) option which allows you to populate a report with blank rows and thus, to fill empty space between [DetailBand](%C2%A0%5Bhttps://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.DetailBand.FillEmptySpace%5D%5B1%5D) and the next band/the end of the page. Read more at [Reporting – Populate Empty Space and Display Cross-Band Content (v19.2)](https://community.devexpress.com/blogs/reporting/archive/2019/10/28/reporting-populate-empty-space-and-display-cross-band-content-v19-2.aspx).
In our documentation, you can find a detailed guide on how to implement such a document layout: [Create a Report with Cross-Band Content and Populated Empty Space](%C2%A0https://docs.devexpress.com/XtraReports/401300/create-popular-reports/create-a-report-with-cross-band-content-and-populated-empty-space) -> [Populate the Empty Space](https://docs.devexpress.com/XtraReports/401300/create-popular-reports/create-a-report-with-cross-band-content-and-populated-empty-space#populate-the-empty-space).

