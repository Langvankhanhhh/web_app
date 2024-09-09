<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webtinhdientich.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính diện tích hình thang</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Tính diện tích hình thang</h2>

            <label for="txtA">Nhập giá trị đáy lớn (a): </label>
            <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
            <br /><br />

            <label for="txtB">Nhập giá trị đáy nhỏ (b): </label>
            <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
            <br /><br />

            <label for="txtH">Nhập giá trị chiều cao (h): </label>
            <asp:TextBox ID="txtH" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnCalculate" runat="server" Text="Tính Toán" OnClick="btnCalculate_Click" />
            <br /><br />

            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>