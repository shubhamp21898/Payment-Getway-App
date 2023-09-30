<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaymentMaster.aspx.cs" Inherits="PaymentGetway.PaymentMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
       
        <script src="../JS/PaymentGetway.js"></script>
       
        <link href="../Web/PaymentGetwayStyle.css" rel="stylesheet" />
    </header>

    <div class="container">
        
        
        <div class="row">
        
          <div class="intro-text">
            <h1>Choose Your Freedom Board Plan</h1>   
          </div>
            <div class="col-0">
                <div class="switch-wrapper">
                    <%--<input id="monthly" type="radio" name="switch" checked>
                    <input id="yearly" type="radio" name="switch">--%>

                    <input id="monthly" type="radio" name="switch" value="monthly" checked>
                    <input id="yearly" type="radio" name="switch" value="yearly">

                    <label data-filter=".monthly" for="monthly">Monthly</label>
                    <label  data-filter=".yearly" for="yearly">Annually </label>
                    <span class="highlighter"></span>
                </div>
            </div>
            
            <div class="col-lg-4 col-md-6 d-flex align-items-stretch">           
                <div class="Plan1 monthly">
                    <h2>Payment Getway Plan 1</h2>
                   
                    <span class="price monthly">$70 <p>/ 1 Month</p></span>
                    
                    <asp:HiddenField ID="hdnfldPlan1" runat="server" />
                    <p>
                        Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint
                    </p>
                    <asp:Button ID="BtnStripe" runat="server" Text="Pay Now" class="btn" OnClick="BtnStripe_Click" />
                    <ul>

                        <li>
                            <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                <g data-v-165629f9="">
                                    <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                </g>
                            </svg>
                            <p>Point 1 Magnam dolores commodi </p>
                        </li>
                        <li>
                            <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                <g data-v-165629f9="">
                                    <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                </g>
                            </svg>
                            <p>Point 1 Magnam dolores commodi </p>

                        </li>
                        <li>
                            <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                <g data-v-165629f9="">
                                    <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                </g>
                            </svg>
                            <p>Point 1 Magnam dolores commodi </p>

                        </li>
                        <li>
                            <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                <g data-v-165629f9="">
                                    <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                </g>
                            </svg>
                            <p>&nbsp Point 1 Magnam dolores commodi </p>

                        </li>
                        <li>
                            <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                <g data-v-165629f9="">
                                    <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                </g>
                            </svg>
                            <p>&nbsp Point 1 Magnam dolores commodi </p>

                        </li>

                    </ul>
                </div>
            </div>
            <div class="col-lg-4 col-md-6 d-flex align-items-stretch price monthly">
                <div class=" Plan1 monthly">
                    <h2>Payment Getway Plan 2</h2>
                     <%--<p>5% off</p>--%>
                   <span class="price monthly">$110 <p>/ 3 Month</p></span>
                    <asp:HiddenField ID="hdnfldPlan2" runat="server" />
                    <p>
                        Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint
                    </p>
                   
                    <asp:Button ID="BtnRazorPay" runat="server" Text="Pay Now" class="btn" OnClick="BtnRazorPay_Click" />
                    <div class="Ulli">
                        <ul>

                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-md-6 d-flex align-items-stretch price monthly">
                <div class=" Plan1 monthly">
                    <h2>Payment Getway Plan 2</h2>
                   <span class="price monthly">$200 <p>/ 6 Month</p></span>
                    <asp:HiddenField ID="HiddenField3" runat="server" />
                    <p>
                        Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint
                    </p>
                   
                    <asp:Button ID="Button4" runat="server" Text="Pay Now" class="btn" OnClick="BtnPaypal_Click" />
                    <div class="Ulli">
                        <ul>

                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-md-6 d-flex align-items-stretch  price yearly "">
                <div class="Plan1 yearly">
                    <h2>Payment Getway Plan 3</h2>
                     <span class="price yearly">$350 <p>/ 1 Year</p></span>
                    <asp:HiddenField ID="hdnfldPlan3" runat="server" />
                    <p>
                        Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint
                    </p>
                  

                    <%--<asp:Button type="submit" runat="server" class="btn btn2" Text="Pay Now"/>--%>
                    <asp:Button ID="Button1" runat="server" Text="Pay Now" class="btn" OnClick="BtnRazorPayPlan3_Click" />

                    <div class="Ul-li">
                        <ul>

                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>

                        </ul>


                    </div>
                </div>
            </div> 
             <div class="col-lg-4 col-md-6 d-flex align-items-stretch  price yearly "">
                <div class="Plan1 yearly">
                    <h2>Payment Getway Plan 3</h2>
                     <span class="price yearly">$600 <p>/ 2 Year</p></span>
                    <asp:HiddenField ID="HiddenField1" runat="server" />
                    <p>
                        Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint
                    </p>
                  

                    <%--<asp:Button type="submit" runat="server" class="btn btn2" Text="Pay Now"/>--%>
                    <asp:Button ID="Button2" runat="server" Text="Pay Now" class="btn" OnClick="BtnRazorPayPlan3_Click" />

                    <div class="Ul-li">
                        <ul>

                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>

                        </ul>


                    </div>
                </div>
            </div> 
            <div class="col-lg-4 col-md-6 d-flex align-items-stretch  price yearly "">
                <div class="Plan1 yearly">
                    <h2>Payment Getway Plan 3</h2>
                     <span class="price yearly">$900 <p>/ 3 Year</p></span>
                    <asp:HiddenField ID="HiddenField2" runat="server" />
                    <p>
                        Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint
                    </p>
                  

                    <%--<asp:Button type="submit" runat="server" class="btn btn2" Text="Pay Now"/>--%>
                    <asp:Button ID="Button3" runat="server" Text="Pay Now" class="btn" OnClick="BtnRazorPayPlan3_Click" />

                    <div class="Ul-li">
                        <ul>

                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>
                            <li>
                                <svg data-v-165629f9="" data-v-9c16c3cc="" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 12 24" aria-label="check" role="presentation" class="h-icon-success" style="width: 12px; height: 24px;">
                                    <g data-v-165629f9="">
                                        <path data-v-165629f9="" d="M12 8.758a.694.694 0 0 1-.217.515l-5.605 5.485-1.053 1.03A.725.725 0 0 1 4.6 16a.724.724 0 0 1-.527-.212l-1.053-1.03-2.803-2.743A.694.694 0 0 1 0 11.5c0-.202.072-.374.217-.515l1.053-1.03a.725.725 0 0 1 .526-.213c.207 0 .382.071.527.213L4.6 12.19l5.078-4.977c.14-.14.33-.216.527-.212.206 0 .382.07.526.212l1.053 1.03c.142.134.22.321.217.516Z"></path>
                                    </g>
                                </svg>
                                <p>&nbsp Point 1 Magnam dolores commodi </p>

                            </li>

                        </ul>


                    </div>
                </div>
            </div> 

           </div>
       
    </div>

    <%-- <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>--%>
    <script src="JS/PaymentGetway.js"></script>
</asp:Content>
