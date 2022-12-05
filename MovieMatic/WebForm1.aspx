<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MovieMatic.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>MovieMatic</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>MovieMatic</h1>
            <div style="width: 400px; border-bottom: 1px solid black"></div>
            <div id="inputPrenotazione">
                <asp:TextBox ID="Name" placeholder="Name.." runat="server"></asp:TextBox>
                <asp:TextBox ID="Lastname" placeholder="Lastname.." runat="server"></asp:TextBox>
                <asp:RadioButton ID="reducedTicket" Text="Ridotto:" runat="server" />
                <asp:DropDownList ID="Sala" runat="server">
                    <asp:ListItem Value="Nord">Sala Nord</asp:ListItem>
                    <asp:ListItem Value="Est">Sala Est</asp:ListItem>
                    <asp:ListItem Value="Sud">Sala Sud</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="Stampa Ticket" OnClick="Button1_Click" />
            </div>
            <div id="dettagliSale" runat="server">
                <div id="detailNord" runat="server">
                    <p>Sala Nord: </p>
                    
                    <asp:Label ID="LabelSalaNord" runat="server" Text=""></asp:Label>
                    <asp:Label ID="NordSoldOut" runat="server" Text="-Ticket esauriti-" visible="false"></asp:Label>
                </div>
                <div id="detailEst">
                    <p>Sala Est: </p>
                    <asp:Label ID="LabelSalaEst" runat="server" Text="">
                    </asp:Label>
                    <asp:Label ID="EstSoldOut" runat="server" Text="-Ticket esauriti-" visible="false"></asp:Label>
                </div>
                <div id="detailSud">
                    <p>Sala Sud: </p>
                    <asp:Label ID="LabelSalaSud" runat="server" Text="">
                    </asp:Label>
                    <asp:Label ID="SudSoldOut" runat="server" Text="-Ticket esauriti-" visible="false"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
