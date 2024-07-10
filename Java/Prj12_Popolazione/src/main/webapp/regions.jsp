<!DOCTYPE html>
<%@page import="org.apache.jasper.tagplugins.jstl.core.ForEach"%>
<%@page import="java.util.List"%>
<html>
<head>
<meta charset="utf-8">
<title>Insert title here</title>
</head>
<body>
<% String s = (String)request.getAttribute("Titolo"); %>
<% List<String> regioni= (List<String>)request.getAttribute("regioni"); %>
<h1>Regioni Italiane</h1>
<h2><%=s%></h2>
<% for(String regione:regioni){ %>
<h2><a href="/istat/province?regione"><%=regione %></a></h2>
<% } %>
</body>
</html>