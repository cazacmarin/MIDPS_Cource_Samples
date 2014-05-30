<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MySite.WebForm1" %>

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
            CellPadding="4" DataKeyNames="id_agenda" DataSourceID="SqlDataSource1" 
            ForeColor="#333333" GridLines="None" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <RowStyle BackColor="#E3EAEB" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="id_agenda" HeaderText="id_agenda" ReadOnly="True" 
                    SortExpression="id_agenda" />
                <asp:BoundField DataField="name1" HeaderText="name1" SortExpression="name1" />
                <asp:BoundField DataField="surname" HeaderText="surname" 
                    SortExpression="surname" />
                <asp:BoundField DataField="phoneNumber" HeaderText="phoneNumber" 
                    SortExpression="phoneNumber" />
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
            DeleteCommand="DELETE FROM [Agenda] WHERE [id_agenda] = @id_agenda" 
            InsertCommand="INSERT INTO [Agenda] ([id_agenda], [name1], [surname], [phoneNumber]) VALUES (@id_agenda, @name1, @surname, @phoneNumber)" 
            SelectCommand="SELECT * FROM [Agenda]" 
            UpdateCommand="UPDATE [Agenda] SET [name1] = @name1, [surname] = @surname, [phoneNumber] = @phoneNumber WHERE [id_agenda] = @id_agenda">
            <DeleteParameters>
                <asp:Parameter Name="id_agenda" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="name1" Type="String" />
                <asp:Parameter Name="surname" Type="String" />
                <asp:Parameter Name="phoneNumber" Type="String" />
                <asp:Parameter Name="id_agenda" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="id_agenda" Type="Int32" />
                <asp:Parameter Name="name1" Type="String" />
                <asp:Parameter Name="surname" Type="String" />
                <asp:Parameter Name="phoneNumber" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
        </td>
    </tr>
    <tr>
    <td></td>
    </tr>
    <tr>
    <td></td>
    </tr>
    <tr>
    <td></td>
    </tr>
    
    </table>
    </div>
    </form>
</body>
</html>
