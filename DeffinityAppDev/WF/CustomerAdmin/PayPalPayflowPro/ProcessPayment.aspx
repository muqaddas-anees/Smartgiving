﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTabSub.master" AutoEventWireup="true" CodeBehind="ProcessPayment.aspx.cs" Inherits="DeffinityAppDev.WF.CustomerAdmin.PayPalPayflowPro.ProcessPayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="page_title" runat="server">
    Process Payment
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="page_description" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Tabs" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="panel_title" runat="server">
     <script language="JavaScript">
         function showMe() {
             var mytoken = document.getElementById('mytoken');
             alert("Token=" + mytoken.value);
         }


         </script>
    <script type="text/javascript">
        window.addEventListener('message', function (event) {
            var token = JSON.parse(event.data);
            var mytoken = document.getElementById('mytoken');
            mytoken.value = token.message;
        }, false);

    </script>
     <asp:Label ID="lblHeader" runat="server" CssClass="header" 
                Text="PayPal Payflow Pro Online Credit Card Transaction"></asp:Label>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="panel_options" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="MainContent" runat="server">
       <div class="form-group row mb-6">
           <div class="col-md-1">
               </div>
          <div class="col-md-10">
    <img src="../../../Content/images/icon_cardconnect.png">
              </div>
           </div>
    <asp:Panel ID="pnlCCD" runat="server">
         <div class="form-group row mb-6">
        
              <asp:Label ID="lblCardERROR" runat="server" EnableViewState="false"></asp:Label>
              
             </div>
    <div class="form-group row mb-6">
         
 <label class="col-sm-2 control-label">Amount to Charge</label>
           <div class="col-sm-9">
                <asp:TextBox ID="txtAmount" runat="server" SkinID="Price_150px" 
                            Width="150px" ReadOnly="true">00.00</asp:TextBox>
            </div>
	
</div>
    <div class="form-group row mb-6">
          
 <label class="col-sm-2 control-label">Card Type</label>
           <div class="col-sm-9">
               <asp:DropDownList ID="ddlCardType" runat="server" SkinID="ddl_200px">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem Value="MASTERCARD" Text="MASTERCARD"></asp:ListItem>
                            <asp:ListItem Selected="True" Value="VISA" Text="VISA"></asp:ListItem>
                   <asp:ListItem Value="DISCOVER" Text="DISCOVER"></asp:ListItem>
                    <asp:ListItem Value="AMEX" Text="AMEX"></asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="ddlCardType" Display="Dynamic" CssClass="error-text" ErrorMessage="Required" 
                            ></asp:RequiredFieldValidator>
            </div>
	
</div>
<div class="form-group row mb-6">
         
 <label class="col-sm-2 control-label">Card Number</label>
           <div class="col-sm-9">
               <div id="pnlCreditCard" runat="server">
                   <asp:TextBox ID="txtCardConnectNumber" runat="server" CssClass="paymentinfo-text" SkinID="txt_50" Visible="false"></asp:TextBox>
                   <asp:TextBox ID="txtCardNumber" runat="server" CssClass="paymentinfo-text" 
                            SkinID="txt_200px" MaxLength="20"></asp:TextBox>
                        &nbsp;<asp:RequiredFieldValidator ID="rfCardnumber" runat="server" 
                            ControlToValidate="txtCardNumber" Display="Dynamic"  ErrorMessage="Please enter Card Number"></asp:RequiredFieldValidator>
                   </div>
               <div id="pnlCardConnect" runat="server">
                   <iframe id="tokenframe" name="tokenframe"  
                       src="https://boltgw.cardconnect.com/itoke/ajax-tokenizer.html?css%3D%252Eerror%7Bcolor%3A%2520red%3B%7D" 
                       frameborder="0" scrolling="no" width="200" height="35" runat="server"></iframe>
                <asp:HiddenField ID="mytoken" runat="server" ClientIDMode="Static" />
                   </div>
               <p>e.g: 4111111111111111</p>
            </div>
	
</div>
    <div class="form-group row mb-6">
         
 <label class="col-sm-2 control-label"> Name on Card</label>
           <div class="col-sm-9">
                <asp:TextBox ID="txtNameOnCard" runat="server" CssClass="paymentinfo-text" 
                            SkinID="txt_200px" MaxLength="250"></asp:TextBox>
                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="txtNameOnCard" Display="Dynamic" ErrorMessage="Please enter Name on Card"></asp:RequiredFieldValidator>
            </div>
	
</div>
    <div class="form-group row mb-6">
         
 <label class="col-sm-2 control-label">Expiration</label>
           <div class="col-sm-9 form-inline">
                <asp:DropDownList ID="ddlMonth" runat="server" CssClass="paymentinfo-text" SkinID="ddl_125px">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlYear" runat="server" CssClass="paymentinfo-text"  SkinID="ddl_125px">
                        </asp:DropDownList>
                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="ddlMonth" Display="Dynamic"  
                            ErrorMessage="Please select Month"></asp:RequiredFieldValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ControlToValidate="ddlYear" Display="Dynamic" 
                            ErrorMessage="Please select Year"></asp:RequiredFieldValidator>
            </div>
	
</div>
    <div class="form-group row mb-6">
         
 <label class="col-sm-2 control-label">Card Security Code</label>
           <div class="col-sm-9">
                <asp:TextBox ID="txtCvv" runat="server" CssClass="paymentinfo-text" 
                            SkinID="txt_75px" MaxLength="10"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtCvv" Display="Dynamic" 
                            ErrorMessage="Please enter CVV"></asp:RequiredFieldValidator>
                         <%-- <p>  A code that is printed (not imprinted) on the back of 
                                a credit card. It consist of 3 or 4 digits. </p>--%>
               <p>e.g: 123 </p>
            </div>
	
</div>
    <div class="form-group row mb-6">
          
 <label class="col-sm-2 control-label"></label>
           <div class="col-sm-9 form-inline">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                            onclick="btnSubmit_Click" />
                        &nbsp;
                        <asp:Button id="btnCancel" runat="server" SkinID="btnCancel" OnClick="btnCancel_Click" CausesValidation="false" />
            </div>
	
</div>
        </asp:Panel>
    <asp:Panel ID="pnlResult" runat="server" Visible="false">
        <div class="form-group row mb-6">
         
              <div class="label label-success" style="font-size:18px"><asp:Literal ID="lblResult" runat="server"></asp:Literal> </div>
        <asp:Label ID="lblMsg" runat="server" SkinID="GreenBackcolor"></asp:Label>
    <%--<asp:Label ID="" runat="server" SkinID="GreenBackcolor"></asp:Label>--%>
        <asp:Label ID="lblError" runat="server" SkinID="RedBackcolor"></asp:Label>
              </div>
            
        <div class="form-group row mb-6">
          <div class="col-md-12 ">
              <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
	</div>
</div>
        </asp:Panel>
     <asp:HiddenField ID="hadid" runat="server" Value="0" />
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="Scripts_Section" runat="server">
    <script type="text/javascript">
        hidetabs();
    </script>
</asp:Content>
