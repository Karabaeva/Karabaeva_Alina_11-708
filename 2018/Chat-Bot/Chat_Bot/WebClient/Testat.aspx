<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Testat.aspx.cs" Inherits="Testat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 357px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Bot" runat="server" Text="botyour"></asp:Label>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button2" runat="server" Text="Да!" OnClick="Button1_Click" Width="95px" />
                    </td>
                </tr> 
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="BotRe" runat="server" ></asp:Label>
                    </td>
                </tr>
                  <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" Width="183px" ></asp:TextBox>
                    </td>
                      <td>
                          <asp:Button ID="Answer" Visible="false" runat="server" Text="Отправить" OnClick="Answer_Click" />
                      </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" ></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="quest1" runat="server"></asp:Label>
                   </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID ="no" Visible="false" runat="server" Text="Нет" OnClick="no_Click" />
                    </td>
                    <td>
                        <asp:Button ID="yes1" Visible ="false" runat="server" Text="Да" OnClick="yes1_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="bot1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="no2" Visible ="false" runat="server" Text="Нет" OnClick="no2_Click"  />
                    </td>
                    <td>
                        <asp:Button ID="yes2" Visible ="false" runat="server" Text="Да" OnClick="yes2_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="bot2" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="no3" Visible ="false" runat="server" Text="Нет" OnClick="no3_Click"  />
                    </td>
                    <td>
                        <asp:Button ID="yes3" Visible ="false" runat="server" Text="Да" OnClick="yes3_Click" />
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style2">
                        <asp:Label ID="bot3" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="no4" Visible ="false" runat="server" Text="Нет" OnClick="no4_Click"  />
                    </td>
                    <td>
                        <asp:Button ID="yes4" Visible ="false" runat="server" Text="Да" OnClick="yes4_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID ="End" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
