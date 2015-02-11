<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<% using(Html.BeginForm()) { %>    
    <ul class="mainMenu">
	        <li>
                <%= Html.ActionLink("Главная", "Index") %>		        
	        </li>
	        <li>
                <%= Html.ActionLink("Наши преимущества", "Index") %>
	        </li>
	        <li>
                <%= Html.ActionLink("Вакансии", "Index") %>
	        </li>
	        <li>
                <%= Html.ActionLink("Продажа автобусов", "Index") %>
	        </li>	
            <li>
                <%= Html.ActionLink("Контакты", "Index") %>
	        </li>
        </ul>
<% } %>

