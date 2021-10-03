<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAD.Master" AutoEventWireup="true" CodeBehind="TrangThemMoiNSX.aspx.cs" Inherits="shopMobileOnline.Admin.TrangThemMoiNSX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .tmdm-container{
           display:flex;
           flex-direction: column;
           padding: 35px 0;
        }
        h3{
            color:#e77f67;
        }
        .tb1{
            margin-left:100px;
        }
        .title{
            width:200px;
        }
        h4{
           font-weight: bold;
        }
        .nut{
            margin-left:40%;
            padding-top:20px;
        }
        .btnThem{
            background-color:#e77f67;
            width:80px;
            height:40px;
            border:none;
            color:white
        }
        .btnHuy{
            background-color:#b2bec3;
           width:80px;
           height:40px;
           border:none;
           color:white;
        }
        .btnThem:hover{
            background-color:#d63031;
        }
        .btnHuy:hover{
            background-color:#636e72;
        }
        .tmdm-error {
            color: red;
            display: block;
            margin-left:5px;
        }
        .lblThongBao{
            color:red;
            margin-left:30%;
            margin-top:10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tmdm-container">
        <h3 style="text-align: center; font-size: 30px; font-weight: bold; margin-bottom: 20px">Thêm nhà sản xuất mới</h3>
        <asp:Table ID="tb1" runat="server" CssClass="tb1">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" CssClass="title">
                    <h4>Nhập Tên Nhà Sản Xuất</h4>
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="txtTenNSX" runat="server" CssClass="tmdm-ten"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Vui lòng nhập tên nhà sản xuất" ControlToValidate="txtTenNSX" CssClass="tmdm-error" Display="Dynamic"></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
         <asp:Label ID="lblThongBao" runat="server" Text="" CssClass="lblThongBao"></asp:Label>
        <div class="nut">
            <asp:Button ID="btnThem"  runat="server" Text="Thêm" Class="btnThem" OnClick="btnThem_Click"  />
            <asp:Button ID="btnHuy"  runat="server" Text="Hủy" Class="btnHuy"  CausesValidation="false" OnClick="btnHuy_Click"/>
        </div>
    </div>
</asp:Content>
