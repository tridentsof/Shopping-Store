<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAD.Master" AutoEventWireup="true" CodeBehind="QLYDanhMuc.aspx.cs" Inherits="shopMobileOnline.Admin.QLYDanhMuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
         .qldm-container{
            margin: 0 0px;
            max-width: 100%;
            min-width: 100%;
            padding: 35px 0;
        }
        .qldm-header {
             display: flex;
             justify-content: center;
             align-items: center;
             margin-bottom: 30px;
        }
        .qldm-btnThemMoi-container {
            position: absolute;
            right: 40px;
            background: #031a43;
            padding: 11px 13px;
            border-radius: 5px;
        }

        .qldm-btnThemMoi-container:hover {
            background: #155e98;
            transition : all 0.2s ease-in;
        }

        .qldm-btnThemMoi-container a {
            display: flex;
            align-items: center;
        }
        .qldm-btnThemMoi-container i,
        .qldm-btnThemMoi-container span {
            display: block;
            color: white;
            
        }
        .qldm-btnThemMoi-container i {
            font-size: 12px;
        }
        .qldm-btnThemMoi-container span{
            font-size: 16px;
            font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
            margin-left: 10px;
        }
        .qldm-table,
        .qldm-column,
        .qldm-row,
        .qldm-item {
            border: 1px solid #adc9fa;  
            text-align: left;
            line-height: 1.3;
            color: #333333;
        }
        .qldm-table{
            margin-left:20%;
        }
        .qldm-column{
           padding: 10px;
           text-align: center;
           vertical-align: middle;
           font-weight: bold;
           background: #ffe4da
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="qldm-container">
        <div class="qldm-header">
            <h3 style="text-align: center; font-size: 30px; font-weight: bold; color: #262626;">Danh sách danh mục</h3>
            <div class="qldm-btnThemMoi-container">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/TrangThemMoiSP.aspx">
                    <i class="fas fa-plus"></i>
                    <span>Thêm mới</span>
                </asp:HyperLink>
            </div>
        </div>
        <table class="qldm-table">
            <thead>
                <tr>
                    <th class="qldm-column" style="min-width: 10px" >ID</th>
                    <th class="qldm-column" style="min-width: 85px" >Sản phẩm</th>
                </tr>
            </thead>
            <tbody>
                <asp:Panel ID="Panel1" runat="server"></asp:Panel>
            </tbody>
        </table>   
        <div class="qldm-btnThemMoi-container" style="margin: 30px auto 0px;position: initial;width: 95px;">
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Admin/TrangThemMoiSP.aspx">
                    <i class="fas fa-plus"></i>
                    <span>Thêm mới</span>
                </asp:HyperLink>
            </div>
    </div>
</asp:Content>
