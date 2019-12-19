﻿<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="display_student_info.aspx.cs" Inherits="LibraryHSE.librarian.display_student_info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    <link href="https://cdn.datatables.net/1.10.19/css/iquery.dataTables.min.css" type="text/css" rel="stylesheet" />
    <script src="https://code.iquery.com/iquery-3.3.1.is"></script>
    <script src="https://cdn.datatables.net/1.10.19/is/iquery.dataTables.min.is"></script>

    <asp:Repeater ID="r1" runat="server">

        <HeaderTemplate>

            <table class="table table-bordered" id="example">
                <thead>
                <tr>
                    <th>image</th>
                <th>FirstName</th>
                <th>LastName</th>
                <th>Enr No</th>
                <th>Username</th>
                <th>Email</th>
                <th>Contact</th>
                <th>Status</th>
                    <th>Active</th>
                    <th>Deactive</th>

                </tr>
                    </thead>
                <tbody>
        </HeaderTemplate>
        
        
        <ItemTemplate>
            <tr>
                <td><img src="../<%#Eval("student_img") %>" height="100" width="100" /></td>
                    <td><%#Eval("firstname") %></td>
                    <td><%#Eval("lastname") %></td>
                    <td><%#Eval("enrollment_no") %></td>
                    <td><%#Eval("username") %></td>
                    <td><%#Eval("email") %></td>
                    <td><%#Eval("contact") %></td>
                    <td><%#Eval("approved") %></td>
                <td><a href="student_active.aspx?id=<%#Eval("id") %>">Active</a></td>
                <td><a href="student_deactive.aspx?id=<%#Eval("id") %>">Deactive</a></td>
            </tr>

        </ItemTemplate>
        
        
        <FooterTemplate>
            </tbody>
            </table>
        </FooterTemplate>

    </asp:Repeater>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#example').DataTable({
                "pagingType": "full_numbers"
            });
        });
    </script>

</asp:Content>
