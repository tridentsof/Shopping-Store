<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAD.Master" AutoEventWireup="true" CodeBehind="QuanLyKMTheoMua.aspx.cs" Inherits="shopMobileOnline.Admin.QuanLyKMTheoMua" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container-discount{
            width: 970px;
            height: 570px;
            background-color: white;
            box-shadow: 0 3px 10px 0 rgb(0 0 0 / 14%);
            margin-left: auto;
            margin-right: auto;
            margin-top: 5%;
            text-align: center;
        }
        button{
            outline: none;
            border: none;
            cursor: pointer;
        }
        .header-discount{
            text-transform: uppercase;
            padding-top: 4%;
            color:#B2D426;
            font-size:20px;
            font-weight:600;
        }
        .discount-wrapper{
            background-color: white;
            display: inline-block;
            height: 200px;
            width: 160px;
            margin-left: 30px;
            margin-top: 5%;
            box-shadow: 0 3px 10px 0 rgb(0 0 0 / 14%);
            border-radius: 3px;
            border: none;
            transition: 0.25s;      
            cursor: pointer;  
        }
        #discount-xuan:hover{
            border: 2px solid yellow;
            
        }
        #discount-ha:hover{
            border: 2px solid #95C623;
        }
        #discount-thu:hover{
            border: 2px solid #7D1128;
        }
        #discount-dong:hover{
            border: 2px solid #0A014F;
        }
        .content-discount{
            padding-top: 20px;
            color: rgb(165, 165, 165);
        }
        .btn-discount{
            margin-top: 70px;
            width: 160px;
            padding: 10px 12px;
            outline:none;
            cursor:pointer;
        }
        .discount-wrapper:hover .detail-discount{
            opacity: 1;
            transform: scale(1);
        }
        .detail-discount{
            font-size: 11px;
            margin-top: 100px;
            height: 80px;
            width: 160px;
            box-shadow: 0 3px 10px 0 rgb(0 0 0 / 14%);
            padding-top: 20px;
            color: rgb(165, 165, 165);
            opacity: 0;
            transition: 0.5s;
            transform: scale(0);
        }
        .btn-xuan{
            background-color: #C98686;
            color: #ffff;   
        }
        .btn-ha{
            background-color: #95C623;
            color: #ffff;
        }
        .btn-thu{
            background-color: #7D1128;
            color: #ffff;
        }
        .btn-dong{
            background-color: #0A014F;
            color: #ffff;
        }
        .p-success{
            display:none;
            color: #B2D426;  
            margin-top:10%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-discount">
        <h1 class="header-discount">Áp dụng khuyến mãi theo mùa</h1>
        <div id="discount-xuan" class="discount-wrapper">
            <p class="content-discount">Mùa xuân</p>
            <asp:Button ID="Button1" runat="server" CssClass="btn-discount btn-xuan" Text="Áp dụng" OnClick="Button1_Click" BorderStyle="None" />
            <div class="detail-discount">Khi áp dụng sẽ tiến hành giảm giá 20% trên tất cả các sản phẩm</div>
        </div>
        <div id="discount-ha" class="discount-wrapper">
            <p class="content-discount">Mùa hạ</p>
            <asp:Button ID="Button2" runat="server" CssClass="btn-discount btn-ha" Text="Áp dụng" OnClick="Button2_Click" BorderStyle="None" />
            <div class="detail-discount">Khi áp dụng sẽ tiến hành giảm giá 10% trên tất cả các sản phẩm</div>
        </div>
        <div id="discount-thu" class="discount-wrapper">
            <p class="content-discount">Mùa thu</p>
            <asp:Button ID="Button3" runat="server" CssClass="btn-discount btn-thu" Text="Áp dụng" OnClick="Button3_Click" BorderStyle="None" />
            <div class="detail-discount">Khi áp dụng sẽ tiến hành giảm giá 30% trên tất cả các sản phẩm</div>
        </div>
        <div id="discount-dong" class="discount-wrapper">
            <p class="content-discount">Mùa đông</p>
            <asp:Button ID="Button4" runat="server" CssClass="btn-discount btn-dong" Text="Áp dụng" OnClick="Button4_Click" BorderStyle="None" />
            <div class="detail-discount">Khi áp dụng sẽ tiến hành giảm giá 50% trên tất cả các sản phẩm</div>
        </div>
        <asp:Label ID="Label1" CssClass="p-success" runat="server" Text="Thành công"></asp:Label>
    </div>
    
    
    
    
</asp:Content>
