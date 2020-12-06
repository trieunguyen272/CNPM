<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KhachHang.aspx.cs" Inherits="gk2.KhachHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:600px; margin: auto">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Mã khách hàng"></asp:Label>
                    
                </td>
                <td><asp:TextBox ID="txtMaKH" runat="server"></asp:TextBox></td>

            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Tên khách hàng"></asp:Label>
                    
                </td>
                <td><asp:TextBox ID="txtTenKH" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="rfvTenKH" runat="server" ErrorMessage="Nhập họ tên!" ControlToValidate="txtTenKH" ForeColor="red"></asp:RequiredFieldValidator>

                </td>

            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Số điện thoại"></asp:Label>
                    
                </td>

                <td><asp:TextBox ID="txtSDT" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblThongBao" runat="server" style="color: red"></asp:Label>
                    
                </td>

                <td>
                    <div>
                        <asp:Button ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click"/>
                        <asp:Button ID="btnSua" runat="server" Text="Sửa" style="margin-left: 15px" OnClick="btnSua_Click"/>
                        <asp:Button ID="btnTim" runat="server" Text="Tìm" style="margin-left: 15px" OnClick="btnTim_Click"/>
                        <asp:Button ID="btnXoa" runat="server" Text="Xoa" style="margin-left: 15px" OnClick="btnXoa_Click"/>
                    </div>
                </td>
            </tr>
            <tr>
                <asp:GridView runat="server" ID="grvKhachHang" AutoGenerateColumns="False" OnSelectedIndexChanged="grvKhachHang_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="MAKH" HeaderText="Mã khách hàng" />
                        <asp:BoundField DataField="HOTEN" HeaderText="Tên khách hàng" />
                        <%--<asp:HyperLinkField DataTextField="HOTEN" HeaderText="Tên khách hàng" NavigateUrl="~/KhachHang.aspx" />--%>
                        <asp:BoundField DataField="SDT" HeaderText="Số điện thoại" />
                        <asp:CommandField ShowSelectButton="True" />
                        
                    </Columns>
                </asp:GridView>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
