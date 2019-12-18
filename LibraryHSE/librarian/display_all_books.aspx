﻿<%@ Page Title="" Language="C#" MasterPageFile="~/librarian/librarian.Master" AutoEventWireup="true" CodeBehind="display_all_books.aspx.cs" Inherits="LibraryHSE.librarian.display_all_books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

        <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Basic Table</strong>
                        </div>
                        <div class="card-body">

                            <asp:Repeater ID="r1" runat="server">
                          <HeaderTemplate> <table class="table">
                              <thead>
                                    <tr>
                                         <th scope="col">books image</th>
                                         <th scope="col">books title</th>
                                         <th scope="col">books pdf</th>
                                         <th scope="col">books video</th>
                                         <th scope="col">author name</th>
                                         <th scope="col">isbn</th>
                                         <th scope="col">avilable qty</th>
                                         <th scope="col">Edit Books</th>
                                    </tr>
                                 </thead>
                                  <tbody>
                          </HeaderTemplate>
                          <ItemTemplate>
                              <tr>
                              <td><img src="<%#Eval("books_image") %>" height="100" width="100"/></td>
                              <td><%#Eval("books_title") %></td>
                              <td><%#Eval("books_pdf") %> <br /> <%#checkpdf(Eval("books_pdf"), Eval("id")) %></td>
                              <td><%#Eval("books_video") %> <br /> <%#checkvideo(Eval("books_video"), Eval("id")) %></td>
                              <td><%#Eval("books_author_name") %></td>
                              <td><%#Eval("books_isbn") %></td>
                              <td><%#Eval("available_qty") %></td>
                              <td><a href="edit_books.aspx?id=<%Eval("id")%>"Edit Books</a></td>
                          </tr>
                          </ItemTemplate>
                                <FooterTemplate>
                                    </tbody>
                                  </table>
                                </FooterTemplate>

                            </asp:Repeater>
                           
                          
                         
                     
                        </div>
                    </div>
                </div>
    </asp:Content>

