<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MySite._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        AutoGenerateSelectButton="True" CellPadding="4" DataKeyNames="id_address" 
                        DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged" ShowFooter="True" 
                        Width="492px" style="text-align: center">
                        <RowStyle BackColor="#E3EAEB" />
                        <Columns>
                            <asp:TemplateField HeaderText="id" SortExpression="id_address">
                              
                                <EditItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("id_address") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
            
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("id_address") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" onClick="lbInsert_Click" ValidationGroup="INSERT" ForeColor="White">Insert</asp:LinkButton>
                                    
                                </FooterTemplate>
                                
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Oras" SortExpression="city">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("city") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="INSERT" runat="server" ErrorMessage="Introduceti numele orasului." ControlToValidate="TextBoxCity" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("city") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Strada" SortExpression="street">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("street") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxStreet" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="INSERT" runat="server" ErrorMessage="Introduceti numele strazii." ControlToValidate="TextBoxStreet" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("street") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tipul adresei" SortExpression="type2">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("type2") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxType" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="INSERT" runat="server" ErrorMessage="Introduceti tipul." ControlToValidate="TextBoxType" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("type2") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Control">
                                <EditItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("id_address") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                   <asp:LinkButton ID="LinkButtonDelete" runat="server" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Sunteti sigur ca doriti sa stergeti aceasta inregistrare?');"></asp:LinkButton>
                     
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:SiteConnection %>" 
                        DeleteCommand="DELETE FROM [Address] WHERE [id_address] = @id_address" 
                        InsertCommand="INSERT INTO [Address] ([id_address], [city], [street], [type2]) VALUES (@id_address, @city, @street, @type2)" 
                        SelectCommand="SELECT * FROM [Address]" 
                        
                        UpdateCommand="UPDATE [Address] SET [city] = @city, [street] = @street, [type2] = @type2 WHERE [id_address] = @id_address" 
                        ondeleted="SqlDataSource1_Deleted">
                        <DeleteParameters>
                            <asp:Parameter Name="id_address" Type="Int32" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="city" Type="String" />
                            <asp:Parameter Name="street" Type="String" />
                            <asp:Parameter Name="type2" Type="Int16" />
                            <asp:Parameter Name="id_address" Type="Int32" />
                        </UpdateParameters>
                        <InsertParameters>
                            <asp:Parameter Name="id_address" Type="Int32" />
                            <asp:Parameter Name="city" Type="String" />
                            <asp:Parameter Name="street" Type="String" />
                            <asp:Parameter Name="type2" Type="Int16" />
                        </InsertParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelError" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                <asp:ValidationSummary runat="server" ValidationGroup="INSERT" ForeColor="Red" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
