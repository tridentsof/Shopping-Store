<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAD.Master" AutoEventWireup="true" CodeBehind="TrangXoaNSX.aspx.cs" Inherits="shopMobileOnline.Admin.TrangXoaNSX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .xoansx-container {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            height: 70vh;
            padding: 35px 0;
        }
        .xoansx-header {
            font-size: 22px;
            font-weight: bold;
            margin-bottom: 30px;
        }
        .lblNSX{
            font-size: 22px;
            color: tomato;
            font-weight: bold;
        }
        .xoansx-btn {
            padding: 10px 15px;
            min-width: 85px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-weight: bold;
            
        }
        .xoansx-btn-xoa {
            background: tomato;
            color: white;
            margin-right: 10px;
        }
        .xoansx-btn-xoa:hover{
            background: #cc330d;
            transition: all 0.2s ease-in;
        }
        .xoansx-btn-huy {
            background: #726f6f;
            color: white;
        }
        .xoansx-btn-huy:hover{
            background: #1a1a1a;
            transition: all 0.2s ease-in;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="xoansx-container">
        <p class="xoansx-header">Bạn có chắc chắn muốn xóa nhà sản xuất :
                       <asp:Label ID="lblNSX" runat="server" Text="" CssClass="lblNSX"></asp:Label>  
        </p> 
             <div class="xoansx-btns">
                    <asp:Button ID="btnXoa" runat="server" Text="Xóa" class="xoansx-btn xoansx-btn-xoa" OnClick="btnXoa_Click"/>
                    <asp:Button ID="btnHuy" runat="server" Text="Hủy" class="xoansx-btn xoansx-btn-huy" OnClick="btnHuy_Click"/>

          </div>
    </div>
</asp:Content>
