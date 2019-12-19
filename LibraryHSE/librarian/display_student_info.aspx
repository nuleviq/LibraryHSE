<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="display_student_info.aspx.cs" Inherits="LibraryHSE.librarian.display_student_info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    <asp:Repeater ID="r1" runat="server">

        <HeaderTemplate>

            <table>
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
            </table>
        </FooterTemplate>

    </asp:Repeater>

</asp:Content>
