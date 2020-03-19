<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobSearch.aspx.cs" Inherits="InigmaITEmployment.HTML.JobSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>JobSearch</title>
</head>
<body>
        <h1>JobSearch</h1>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtJobSearch" runat="server" style="margin-left: 0px" Width="495px"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        </p>
        <asp:ListBox ID="lstJob" runat="server" Height="276px" Width="509px" OnSelectedIndexChanged="lstJob_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Button ID="btnAddJob" runat="server" Text="Add " Width="64px" OnClick="btnAddJob_Click" />
            <asp:Button ID="btnUpdateJob" runat="server" Text="Update" Width="74px" OnClick="btnUpdateJob_Click" />
            <asp:Button ID="btnDeleteJob" runat="server" Text="Delete" Width="69px" OnClick="btnDeleteJob_Click" />
            <asp:Button ID="btnViewJob" runat="server" OnClick="btnViewJob_Click" Text="View Job" />
        </p>
    </form>
</body>
</html>