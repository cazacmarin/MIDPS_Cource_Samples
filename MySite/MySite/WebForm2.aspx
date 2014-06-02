<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MySite.WebForm2" %>

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
            DataKeyNames="id_email" DataSourceID="SqlDataSource1" CellPadding="4" 
            ForeColor="#333333" GridLines="None">
            <RowStyle BackColor="#E3EAEB" />
            <Columns>
                <asp:BoundField DataField="id_email" HeaderText="id_email" ReadOnly="True" 
                    SortExpression="id_email" />
                <asp:BoundField DataField="eMailAddress" HeaderText="eMailAddress" 
                    SortExpression="eMailAddress" />
                <asp:BoundField DataField="type1" HeaderText="type1" SortExpression="type1" />
                <asp:BoundField DataField="id_eMail_Agenda" HeaderText="id_eMail_Agenda" 
                    SortExpression="id_eMail_Agenda" />
            </Columns>
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        </td>
    </tr>
    <tr>
    <td></td>
    </tr>
    <tr>
    <td>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:SiteConnection %>" 
            DeleteCommand="DELETE FROM [eMail] WHERE [id_email] = @id_email" 
            InsertCommand="INSERT INTO [eMail] ([id_email], [eMailAddress], [type1], [id_eMail_Agenda]) VALUES (@id_email, @eMailAddress, @type1, @id_eMail_Agenda)" 
            SelectCommand="SELECT * FROM [eMail] WHERE ([id_eMail_Agenda] = @id_eMail_Agenda)" 
            UpdateCommand="UPDATE [eMail] SET [eMailAddress] = @eMailAddress, [type1] = @type1, [id_eMail_Agenda] = @id_eMail_Agenda WHERE [id_email] = @id_email">
            <SelectParameters>
                <asp:SessionParameter Name="id_eMail_Agenda" SessionField="idagenda" 
                    Type="Int32" />
            </SelectParameters>
            <DeleteParameters>
                <asp:Parameter Name="id_email" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="eMailAddress" Type="String" />
                <asp:Parameter Name="type1" Type="Int16" />
                <asp:Parameter Name="id_eMail_Agenda" Type="Int32" />
                <asp:Parameter Name="id_email" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="id_email" Type="Int32" />
                <asp:Parameter Name="eMailAddress" Type="String" />
                <asp:Parameter Name="type1" Type="Int16" />
                <asp:Parameter Name="id_eMail_Agenda" Type="Int32" />
            </InsertParameters>
        </asp:SqlDataSource>
        </td>
    </tr>
    <tr>
    <td>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        </td>
    </tr>
    
    <tr>
    <td>
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        </td>
    </tr>
    
    </table>
    </div>
    </form>
</body>
</html>
