<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebHost.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form runat="server">

   <asp:ObjectDataSource ID="dataSource" runat="server" 
     SelectMethod  ="Select" 
     SelectCountMethod="Count"
     EnablePaging="true"
     TypeName="WebForms.Services.ProjectReportingService">
  </asp:ObjectDataSource>


     <asp:GridView runat="server" DataSourceID="dataSource" AutoGenerateColumns="false">
       <Columns>
         <asp:BoundField DataField="Territory" HeaderText="Territory" SortExpression="Territory" />
         <asp:BoundField DataField="Country"  HeaderText ="Country" SortExpression="Country" />
         <asp:BoundField DataField="ProjectCode"  HeaderText ="ProjectCode" SortExpression="ProjectCode" />
         <asp:BoundField DataField="ProjectTitle"  HeaderText ="ProjectTitle" SortExpression="ProjectTitle" />
         <asp:BoundField DataField="ClientName"  HeaderText ="ClientName" SortExpression="ClientName" />
      </Columns>
     </asp:GridView>
    </form>
</body>
</html>
