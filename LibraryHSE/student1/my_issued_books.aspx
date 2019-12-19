<%@ Page Title="" Language="C#" MasterPageFile="~/student1/student.Master" AutoEventWireup="true" CodeBehind="my_issued_books.aspx.cs" Inherits="LibraryHSE.student1.my_issued_books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    <div class="breadcrumbs">
        <div class="col-sm-4">
            <div class="page-header float-left">
                <div class="page-title">
                    <h1>My issued books</h1>
                </div>
            </div>
        </div>
    </div>
    <div class="container-fluid" style="min-height:500px; background-color:white">
        <asp:DataList ID="1d" runat="server">
            <HeaderTemplate>
                <table class="table table-bordered">
            </HeaderTemplate>
            <ItemTemplate>

            </ItemTemplate>
            
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:DataList>

    </div>

</asp:Content>
