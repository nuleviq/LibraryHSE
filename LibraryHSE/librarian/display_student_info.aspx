<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="display_student_info.aspx.cs" Inherits="LibraryHSE.librarian.display_student_info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server"> 

    <asp:Repeater ID="r1" runat="server">

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

            </tr>

        
            <HeaderTemplate></HeaderTemplate>
        
            
            <ItemTemplate>

                <tr>
                    <td><img src="" height="100" width="100" /></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>

            </ItemTemplate>
        
            
            <FooterTemplate>

            </table>

        </FooterTemplate>

    </asp:Repeater>

</asp:Content>


