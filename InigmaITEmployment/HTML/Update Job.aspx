<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update Job.aspx.cs" Inherits="InigmaITEmployment.HTML.Update_Job" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Job</title>
</head>
<body style="height: 583px">
    <h1>Update Job</h1>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblUpdateJobName" runat="server" style="z-index: 1; left: 15px; top: 130px; position: absolute" Text="Job Name"></asp:Label>
        <asp:Label ID="lblUpdateJobDescription" runat="server" style="z-index: 1; left: 16px; top: 177px; position: absolute" Text="Job Description"></asp:Label>
        <asp:Label ID="lblUpdateDate" runat="server" style="z-index: 1; left: 15px; top: 332px; position: absolute; height: 22px; width: 98px" Text="Date Posted"></asp:Label>
        <asp:Label ID="lblUpdateStaffId" runat="server" style="z-index: 1; left: 15px; top: 379px; position: absolute" Text="Staff ID"></asp:Label>
        <asp:TextBox ID="txtUpdateJobName" runat="server" style="z-index: 1; left: 175px; top: 130px; position: absolute; width: 359px"></asp:TextBox>
        <asp:TextBox ID="txtUpdateDescription" runat="server" style="z-index: 1; left: 176px; top: 171px; position: absolute; width: 356px; height: 114px"></asp:TextBox>
        <asp:TextBox ID="txtUpdateDate" runat="server" style="z-index: 1; left: 173px; top: 332px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtUpdateStaffId" runat="server" style="z-index: 1; left: 172px; top: 374px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnUpdateJob" runat="server" style="z-index: 1; left: 270px; top: 517px; position: absolute; width: 63px" Text="Update" />
        <asp:Button ID="btnCancelUpdate" runat="server" OnClick="btnCancelUpdate_Click" style="z-index: 1; left: 343px; top: 518px; position: absolute; width: 63px" Text="Cancel" />
        <asp:Label ID="lblUpdateError" runat="server" style="z-index: 1; left: 275px; top: 459px; position: absolute" Visible="False"></asp:Label>
    </form>
</body>
</html>
