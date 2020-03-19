<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete Job.aspx.cs" Inherits="InigmaITEmployment.HTML.Delete_Job" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Job</title>
</head>
<body style="height: 792px">
    <h1>Delete Job</h1>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteJobName" runat="server" style="z-index: 1; left: 25px; top: 118px; position: absolute" Text="Job Name"></asp:Label>
        <asp:Label ID="lblDeleteJobDescription" runat="server" style="z-index: 1; left: 26px; top: 164px; position: absolute" Text="Job Description"></asp:Label>
        <asp:Label ID="lblDeleteDate" runat="server" style="z-index: 1; left: 26px; top: 362px; position: absolute" Text="Date Posted"></asp:Label>
        <asp:Label ID="lblDeleteStaffID" runat="server" style="z-index: 1; left: 25px; top: 403px; position: absolute" Text="Staff ID"></asp:Label>
        <asp:TextBox ID="txtDeleteJobName" runat="server" style="z-index: 1; left: 196px; top: 111px; position: absolute; width: 372px"></asp:TextBox>
        <asp:TextBox ID="txtDeleteJobDescription" runat="server" style="z-index: 1; left: 196px; top: 163px; position: absolute; width: 371px; height: 153px"></asp:TextBox>
        <asp:TextBox ID="txtDeleteDate" runat="server" style="z-index: 1; left: 196px; top: 363px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDeleteStaffId" runat="server" style="z-index: 1; left: 196px; top: 407px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDeleteError" runat="server" style="z-index: 1; left: 292px; top: 454px; position: absolute" Visible="False"></asp:Label>
        <asp:Button ID="btnDeleteJob" runat="server" style="z-index: 1; left: 276px; top: 499px; position: absolute; width: 63px" Text="Delete" />
        <asp:Button ID="btnCancelDelete" runat="server" OnClick="btnCancelDelete_Click" style="z-index: 1; left: 350px; top: 499px; position: absolute; width: 63px" Text="Cancel" />
    </form>
</body>
</html>
