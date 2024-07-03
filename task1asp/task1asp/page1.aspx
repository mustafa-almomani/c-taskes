<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="task1asp.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 140px;
            height: 16px;
        }
        #TextArea1 {
            margin-top: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Name"></asp:Label>
            <asp:TextBox  ID="Text1" type="text" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label runat="server" Text="Email"></asp:Label>
                       <asp:TextBox  ID="TextBox2" type="text" runat="server"></asp:TextBox>

        </p>
        <p>
            <asp:Label runat="server" Text="ID"></asp:Label>
                       <asp:TextBox  ID="TextBox3" type="text" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButton ID="RadioButton1" GroupName="ma" runat="server" Text="male" />
        <asp:RadioButton ID="RadioButton2" GroupName="ma" runat="server" Text="female" />

        <p>

        <asp:Label runat="server" Text="courses:"></asp:Label>

            <asp:CheckBox ID="CheckBox1" value="HTML" runat="server"  Text="html" />
            <asp:CheckBox ID="CheckBox2" value="css" runat="server" Text="css" />
            <asp:CheckBox ID="CheckBox3" value="c#" runat="server" Text="c#" />
            
       
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
        </p>

        <div>
       
            <asp:TextBox  ID="Text6" type="text" runat="server"></asp:TextBox>



        <p>
            <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />

     

        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>

            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label11" runat="server" Text=""></asp:Label>

        </p>
     

            <div >
               result: <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
            </div>


        </div>
        <p>
                <asp:Label ID="Label12" runat="server" Text="num1"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </p>
        <p>
                <asp:Label ID="Label13" runat="server" Text="num2"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </p>
        <p>
                <asp:Button ID="Button2" runat="server" Text="+" OnClick="Button2_Click" Width="74px" />
                <asp:Button ID="Button4" runat="server" Text="*" Width="74px" OnClick="Button4_Click" />
                <asp:Button ID="Button3" runat="server" Text="-" Width="74px" OnClick="Button3_Click" />
                <asp:Button ID="Button5" runat="server" Text="/" Width="74px" OnClick="Button5_Click" />
                </p>


    </form>
</body>
</html>
