<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RealEstate.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .tblColumn {
            background-color: #2c2c2c;
            color: white;
        }
        .table{
            width: 80%;
            background-color: white;
        }
       
    </style>
    <div class="content" style="padding-top: 5%" align="center">

        <table class="table table-bordered table-hover">
            <thead class="tblColumn">
                <tr>
                    <td>User ID</td>
                    <td>Username</td>
                    <td>Password</td>
                    <td>Created Date</td>
                    <td>Updated Date</td>
                </tr>
            </thead>
            <asp:Repeater ID="repPeople" runat="server">
                <ItemTemplate>
                    <tbody>
                        <td><%# Eval("usrId") %></td>
                        <td><%# Eval("usrName") %></td>
                        <td><%# Eval("usrPassword") %></td>
                        <td><%# Eval("usrCreatedDate") %></td>
                        <td><%# Eval("usrUpdateDate") %></td>
                    </tbody>

                </ItemTemplate>
            </asp:Repeater>
        </table>

    </div>
    <script src="Scripts/customJs/users.js"></script>
</asp:Content>
