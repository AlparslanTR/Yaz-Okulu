<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Dersler.aspx.cs" Inherits="Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ders Seçin"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Öğrenci ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-warning" Text="Ders Talep Oluştur" OnClick="Button1_Click" />
    </form>

    <table class="table table-bordered table-hover">
        <tr>
            <th>Ders ID</th>
            <th>Ders Ad</th>
            <th>Minimum Kontenjan</th>
            <th>Maximum Kontenjan</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <tr>
                        <td><%#Eval("ID") %></td>
                        <td><%#Eval("DERSAD") %></td>
                        <td><%#Eval("MIN") %></td>
                        <td><%#Eval("MAX") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

