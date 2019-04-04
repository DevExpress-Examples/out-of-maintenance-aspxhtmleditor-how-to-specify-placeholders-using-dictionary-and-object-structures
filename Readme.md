<!-- default file list -->
*Files to look at*:

* [Placeholder.aspx](./CS/Placeholder/Placeholder.aspx) (VB: [Placeholder.aspx](./VB/Placeholder/Placeholder.aspx))
* [Placeholder.aspx.cs](./CS/Placeholder/Placeholder.aspx.cs) (VB: [Placeholder.aspx.vb](./VB/Placeholder/Placeholder.aspx.vb))
<!-- default file list end -->
# ASPxHtmlEditor - How to specify placeholders using dictionary and object structures


<p>This example demonstrates how to replace placeholders with data specified as a dictionary and as an object. For this purpose, we use two overloads of the <a href="http://help.devexpress.com/#AspNet/DevExpressWebASPxHtmlEditorASPxHtmlEditor_ReplacePlaceholderstopic">ReplacePlaceholders</a> server-side method.</p>
<p>In this example, we have created <strong>Insert Signature</strong> and <strong>Insert Date </strong>buttons.</p>
<p>When the <strong>Insert Signature</strong> button is clicked, the <strong>FirstName</strong> and <strong>LastName</strong> placeholders are replaced using the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxHtmlEditorASPxHtmlEditor_ReplacePlaceholderstopic%288Yxmrw%29">ReplacePlaceholders(string html, Dictionary <String, String> placeholders)</a> method. This method gets the placeholders contained in a dictionary.</p>
<p>When the <strong>Insert Date</strong> button is clicked, the <strong>DateNow</strong> and <strong>TimeNow</strong> placeholders are replaced using another <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxHtmlEditorASPxHtmlEditor_ReplacePlaceholderstopic%28SwhGdw%29">ReplacePlaceholders(string html, object placeholders)</a> method overload. This method gets the placeholders contained in an object.</p>

<br/>


