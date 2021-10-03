<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAD.Master" AutoEventWireup="true" CodeBehind="DoanhThuTheoTungThang.aspx.cs" Inherits="shopMobileOnline.Admin.DoanhThuTheoTungThang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
         .adtrangchu-container {
            display: flex;
            flex-direction: column;
            align-items: center;
            padding: 45px 0;
        }

        

        .section-thongKe {
            width: 60%;
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin: 10px auto 50px;
        }


        .section-item {
            //border: 1px solid #052f87;
            height: 140px;
            box-shadow: rgba(0,0,0,0.15) 0px 2px 8px;
            border-radius: 5px;
        }

        .section-item-header {
            width: 100%;
            text-align: center;
            font-size: 15px;
            font-weight: bold;
            font-family: Arial, sans-serif;
            background: #2f3542;
            padding: 12px 0;
            color: white;
            //border-radius: 4px;
           

        }
        

        .section-item-number {
            display: flex;
            height: 100px;
            justify-content: center;
            align-items: center
        }
        .section-item-number span {
            font-size: 24px;
            font-family:  Arial, sans-serif;
            color: #052f87;
        }
        .qldh-container{
            margin: 0 0px;
            max-width: 100%;
            min-width: 100%;
            display: flex;
            flex-direction: column;
            justify-content: center;
           padding-bottom: 80px;
           overflow-y: scroll;
           
        }
        .qldh-container h4 {
            margin: 0 auto;
            font-size: 30px;
            font-weight: bold; 
            color: #262626;
        }
        
        .table {
            width: 100%;
            margin: 0 auto;
        }
        .table,
        .table-th,
        .table-tr,
        .table-item {
            border: 1px solid #adc9fa;  
            text-align: left;
            line-height: 1.3;
            color: #333333;
        }
        .table-th{
           padding: 10px;
           text-align: center;
           vertical-align: middle;
           font-weight: bold;
           background: #ffe4da
        }
        .table-td {
            text-align: center;
            font-size: 12px;
            font-weight: 500;
            font-family:Arial, sans-serif;
            
        }
        .table-item {
            padding: 10px;
        }
        .table-tr:nth-child(even){
            background: #fff9f9;
        }
        #table-item-tensp a {
            font-weight: bold;
            color: #031a43
        }
        #table-item-tensp a:hover{
            color: #0654a9;
            transition : all 0.1s ease-in;
        }
        .qldh-btnXem {
            color: #052f87;
        }
        .nut{
            margin-left:40%;
            padding-top:20px;
        }
        
        .btnTim:hover{
            background-color:#d63031;
        }
        .btnTim{
            background-color:#e77f67;
            width:80px;
            height:40px;
            border:none;
            color:white
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p >       
        <div class="nut">
            <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnTim"  runat="server" Text="Tìm Kiếm" Class="btnTim" OnClick="btnTim_Click" Height="26px" />
            </div>
    <div class="adtrangchu-container">
         <section class="section-thongKe">
            <div class="auto-style1">
                <p class="section-item-header header-choDuyet">Doanh Theo Từng Tháng</p>
                <table class="table" border="1">
                <tr  class="table-tr">
                    <th class="table-th">ID</th>
                    <th class="table-th" style="max-width:50px">Tháng</th>
                    <th class="table-th">Tổng</th>
                    <%--<th class="table-th"  style="min-width: 80px">Xem</th>--%>
                </tr>
                <asp:Panel ID="Panel1" runat="server"></asp:Panel>
            </table>
            </div>
</asp:Content>
