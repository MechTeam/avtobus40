<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Bus40.Models.WebTemplateObjects.ServiceWTO>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">
    <% Html.RenderAction("Header", "Block"); %>
</asp:Content>

<asp:Content ID="SliderContnent" ContentPlaceHolderID="MainHeaderContent" runat="server">  
    <div id="slider">
        <% Html.RenderPartial("Slider"); %>    
    </div>  
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">    
    
    <% foreach (var item in Model) { %>
        <div class="serviceTicket">
            <% Html.RenderPartial("Service", item); %>
        </div>
    <% } %>
    
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="FooterContent" runat="server">
    <% Html.RenderAction("Footer", "Block"); %>    
</asp:Content>

