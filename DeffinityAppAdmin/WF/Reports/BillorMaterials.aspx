<%@ Page Language="C#" AutoEventWireup="true" Inherits="Reports_BillorMaterialsPage" Title ="Billor Material" Codebehind="BillorMaterials.aspx.cs" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Materials</title>
</head>
<body>
    <form id="form1" runat="server">
     
    <div class="bodyframe">
<div class="header" >
<div style="clear:both"></div>
<div class="content">
<div class="content_bodyfull1">
<%--<div class="sections">--%>
<div class="clr"></div>
<div  class="sec_body1">
<asp:Label ID="lblReportTitle" CssClass="sec_header" runat="Server" EnableViewState="False" Width="100%" />
<%--<CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" DisplayGroupTree="False" />
<CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
</CR:CrystalReportSource>
--%>    </div>
	</div>
</div>
</div>

<div class="clr"></div>




</div>
    </form>
</body>
</html>
