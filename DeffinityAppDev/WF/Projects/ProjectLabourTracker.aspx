﻿<%@ Page Title="" Language="C#" MasterPageFile="~/WF/MainTab.master" AutoEventWireup="true" Inherits="ProjectLabourTracker" Codebehind="ProjectLabourTracker.aspx.cs" %>

 
<%@ Register Src="controls/ProjectTabs.ascx" TagName="BuildProjectTabs" TagPrefix="uc1" %>
<%@ Register Src="controls/Project_FinancialSubtab.ascx" TagName="Project_FinalcialSubtab"
    TagPrefix="uc2" %>
    <%@ Register Src="controls/PTLabourTracker.ascx" TagName="Labour"
    TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Tabs" runat="Server">
   
    <uc1:BuildProjectTabs ID="BuildProjectTabs1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="page_title" runat="Server">
    <%= Resources.DeffinityRes.ProjectManagement%>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="page_description" runat="Server">
   
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="panel_title" runat="Server">
      Project Tracker - <Pref:ProjectRef ID="ProjectRef1" runat="server" />
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="panel_options" runat="Server">
     <asp:HyperLink ID="HyperLink1" runat="server" SkinID="BackToPipeline"></asp:HyperLink>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
   
     <uc2:Project_FinalcialSubtab ID="Project_FinalcialSubtab1" runat="server" />
     <uc3:Labour ID="Labour1" runat="Server" />
     <%: System.Web.Optimization.Scripts.Render("~/bundles/grid") %>

<script type="text/javascript">
    // Sys.WebForms.PageRequestManager.getInstance().add_endRequest(GridResponsiveCss);
    activeTab('Project Tracker');
    GridResponsiveCss();
</script> 
    
</asp:Content>

