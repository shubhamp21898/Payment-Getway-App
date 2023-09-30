<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="StripePay.aspx.cs" Inherits="PaymentGetway.StripePay" %>

<%--MasterPageFile="~/Site.Master"
    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<form runat="server" method="post" >
    <div>
        <div>
            <h1>Payment Gateway Using Stripe</h1>


            <%--<asp:Button ID="payButton" runat="server" Text="Pay Now" OnClick="payButton_Click"  />--%

           
        </div>
    </div>
</form>

    

</asp:Content>--%>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Page</title>
    <script src="https://js.stripe.com/v3/"></script>
    <style>

        .btn{
            color:cornflowerblue;
            width:10%;
            height:5%;
        }

        .btn:hover{
           box-shadow:1px 0px 10px lightgrey;
          
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
           <asp:Button ID="CreateCheckoutSession" class="btn"   runat="server" Text="Pay Now Stripe" OnClick="CreateCheckoutSession_Click" />
        </div>
    </form>
   
</body>
</html>

