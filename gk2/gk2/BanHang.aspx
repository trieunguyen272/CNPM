<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BanHang.aspx.cs" Inherits="gk2.BanHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:700px;margin: auto">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Chọn mặt hàng"></asp:Label>
                    
                </td>
                <td><asp:DropDownList ID="ddlMatHang" runat="server">
                    </asp:DropDownList></td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Chọn khách hàng"></asp:Label>
                    
                </td>
                <td><asp:DropDownList ID="ddlKhachHang" runat="server">
                    </asp:DropDownList></td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Ngày bán"></asp:Label>
                    
                </td>
                <td><asp:TextBox ID="txtNgayBan" runat="server"></asp:TextBox>
                    <asp:Calendar ID="cldNgayBan" runat="server" OnSelectionChanged="cldNgayBan_SelectionChanged" Visible="false"></asp:Calendar>
                    <asp:LinkButton ID="lnkNgayBan" runat="server" OnClick="lnkNgayBan_Click" Text="Mở lịch"></asp:LinkButton>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Số lượng"></asp:Label>
                    
                </td>
                <td><asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblThongBao" runat="server"  style="color: red"></asp:Label>
                    
                </td>
                <td><asp:Button ID="btnBanHang" runat="server" Text="Bán hàng" OnClick="btnBanHang_Click"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblThanhTien" runat="server" style="color: red"></asp:Label>
                    
                </td>
                </tr>
             <tr>
                <td>
                    <asp:Label ID="lbl" runat="server" style="color: red"></asp:Label>
                    
                </td>
                </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
