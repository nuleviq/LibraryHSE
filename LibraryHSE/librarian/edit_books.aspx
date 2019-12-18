<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">
    </form>
    <asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

        <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Update Books</strong>
                        </div>
                        <div class="card-body">
                          <!-- Credit Card -->
                          <div id="pay-invoice">
                              <div class="card-body">
                                  <form action="" id="fo1" runat="server" method="post" novalidate="novalidate">
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Title</label>
                                          <asp:TextBox ID="bookstitle" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                      
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Image</label>
                                          <asp:FileUpload ID="f1" runat="server" class="form-control"/>
                                      </div>
                                     
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Author Name</label>
                                          <asp:TextBox ID="authorname" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                     
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Isbn</label>
                                          <asp:TextBox ID="isbn" runat="server" class="form-control"></asp:TextBox>
                                      </div>

                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Books Qty</label>
                                          <asp:TextBox ID="qty" runat="server" class="form-control"></asp:TextBox>
                                      </div>

                                      <div>
                                          
                                          <asp:Button ID="b1" runat="server" class="btn btn-lg btn-info btn-block" Text="Update Books" />
                                      </div>
                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->
    </asp:Content> 
</body>
</html>
