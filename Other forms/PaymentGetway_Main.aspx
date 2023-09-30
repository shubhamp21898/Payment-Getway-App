<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PaymentGetway_Main.aspx.cs" Inherits="PaymentGetway.PaymentGetway_Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #imgRzr{
            width:30%;
            height:25%;
        }
        .img{
             width:20%;
            height:20%;
        }
        /*#BtnStripe{
            background-color:aquamarine;
        }*/
        

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div >
             <asp:Image class="img"  src="Img/stripe-icon.svg" runat="server" />
            <h2>Payment Getway using Stripe</h2>
            <asp:Button ID="BtnStripe" runat="server" Text="Stripe" class="btn btn-primary"  OnClick="BtnStripe_Click"  />
        </div><br />
      
        <div >
             <asp:Image ID="imgRzr" src="Img/razorpay-icon.svg" runat="server" />
            <h2 style="height: 34px">Payment Getway using Razor Pay</h2>
            <asp:Button ID="BtnRazorPay" runat="server" Text="RazorPay" BackColor="#33CCFF" BorderStyle="Solid" OnClick="BtnRazorPay_Click" />
        
        </div>
        
    </form>
</body>
</html>
