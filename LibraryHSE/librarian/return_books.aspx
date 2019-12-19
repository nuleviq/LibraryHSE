<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="return_books.aspx.cs" Inherits="LibraryHSE.librarian.return_books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    <div class="breadcrumbs">
        <div class="col-sm-4">
            <div class="page-header float-left">
                <div class="page-title">
                    <h1>Return book</h1>
                </div>
            </div>
        </div>
    </div>
    <div class="container-fluid" style="min-height:500px; background-color:white">
        <br /><br />
        <asp:DataList ID="d1" runat="server">
            <HeaderTemplate>
                <table class="table table-bordered">
                    <tr>
                        <th>student_enrollment_no</th>
                        <th>boooks_isbn</th>
                        <th>books_issue_date</th>
                        <th>books_approx_return_date</th>
                        <th>student_username</th>
                        <th>is_book_return</th>
                        <th>books_return_date</th>
                        <th>lateday</th>
                        <th>Penalty ($)</th>
                        <th>Return Books</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("student_enrollment_no") %></td>
                    <td><%#Eval("books_isbn") %></td>
                    <td><%#Eval("books_issue_date") %></td>
                    <td><%#Eval("books_approx_return_date") %></td>
                    <td><%#Eval("student_username") %></td>
                    <td><%#Eval("is_book_return") %></td>
                    <td><%#Eval("books_return_date") %></td>
                    <td><%#Eval("lateday") %></td>
                    <td><%#Eval("penalty") %></td>
                    <td><a href="returnbook.aspx?id=<%#Eval("id") %>">Return Books</a></td>
                </tr>
            </ItemTemplate>
            
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:DataList>

    </div>

</asp:Content>
