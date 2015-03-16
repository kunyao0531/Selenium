<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Selenium.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-2.1.3.js"></script>
    <script>
        $(document).ready(function () {
            $("#dosomething").click(function () {
                var a = parseInt($("#money").val());

                $("#90").text("九折 : " + a * 0.9);
                $("#80").text("八折 : " + a * 0.8);
                $("#70").text("七折 : " + a * 0.7);
                $("#60").text("六折 : " + a * 0.6);
            })
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    原價 : <input type="text" id="money" style="font-family:arial; font-size:12pt;"/> <button type="button" id="dosomething">GO</button>
    </div>
        <hr />
        <div id="90"></div>
        <div id="80"></div>
        <div id="70"></div>
        <div id="60"></div>
    </form>
</body>
</html>
