<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobs.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>

    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="page-header"></div>

            <h2>Papa Bob's Pizza</h2>
            <p>Pizza to Code By</p>

            <div class="form-group">

            <label>Size:</label>
            <asp:DropDownList ID="sizeDropDown" runat="server" CssClass="form-control">
            <asp:ListItem Text="Choose One ..." Selected="True"></asp:ListItem>
            <asp:ListItem Text="Small (12 inch - $12)" Value="Small"></asp:ListItem>
            <asp:ListItem Text="Medium (14 inch - $14)" Value="Medium"></asp:ListItem>
            <asp:ListItem Text="Large (16 inch - $16)" Value="Large"></asp:ListItem>
            </asp:DropDownList>

            <br />

            <label>Crust:</label>
            <asp:DropDownList ID="crustDropDown" runat="server" CssClass="form-control">
            <asp:ListItem Text="Choose One ..." Selected="True"></asp:ListItem>
            <asp:ListItem Text="Regular" Value="Regular"></asp:ListItem>
            <asp:ListItem Text="Thin" Value="Thin"></asp:ListItem>
            <asp:ListItem Text="Thick (+ $2)" Value="Thick"></asp:ListItem>
            </asp:DropDownList>

            </div>

            <div class="custom-checkbox">

            <label><asp:CheckBox ID="sausageCheckBox" runat="server" /> Sausage</label><br />
            <label><asp:CheckBox ID="pepperoniCheckBox" runat="server" /> Pepperoni</label><br />
            <label><asp:CheckBox ID="onionCheckBox" runat="server" /> Onion</label><br />
            <label><asp:CheckBox ID="greenPepperCheckBox" runat="server" /> Green Peppers</label>

            </div>

            <h3>Deliver to:</h3>
            <div class="form-group">
            <label>Name:</label>
            <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox><br />
            <label>Address:</label>
            <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox><br />
            <label>Zip Code:</label>
            <asp:TextBox ID="zipCodeTextBox" runat="server" CssClass="form-control"></asp:TextBox><br />
            <label>Phone:</label>
            <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <h3>Payment:</h3>

            <div class="radio"><label><asp:RadioButton ID="cashRadio" runat="server" GroupName="PaymentGroup" Checked="true" /> Cash</label></div>

            <div class="radio"><label><asp:RadioButton ID="creditRadio" runat="server" GroupName="PaymentGroup" /> Credit</label></div>
 
            <asp:Button ID="orderButton" Text="Order" runat="server" OnClick="orderButton_Click" cssclass="btn btn-lg btn-primary"/>

            <asp:Label ID="validationLabel" Text="" Visible="false" runat="server" CssClass="bg-danger"></asp:Label>

            <h3>Total Cost:</h3>
            <div class="form-group"><asp:Label ID="resultLabel" runat="server"></asp:Label></div>

        </div>
    </form>
</body>
</html>
