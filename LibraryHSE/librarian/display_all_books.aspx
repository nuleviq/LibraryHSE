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
                            <strong class="card-title">Basic Table</strong>
                        </div>
                        <div class="card-body">

                            <asp:Repeater ID="r1" runat="server">
                          <HeaderTemplate> <table class="table">
                              <thead>
                                    <tr>
                                         
                                         <th scope="col">books title</th>
                                         <th scope="col">Last</th>
                                         <th scope="col">Handle</th>
                                    </tr>
                                 </thead>
                                  <tbody>
                          </HeaderTemplate>
                          <ItemTemplate>
                              <tr>
                              <td>1</td>
                              <td>Mark</td>
                              <td>Otto</td>
                              <td>@mdo</td>
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
</body>
</html>
