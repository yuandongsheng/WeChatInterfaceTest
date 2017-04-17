<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="Spirite.View.WeChatWeb.Page1.UserRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta name="viewport" http-equiv="Content-Type" content="text/html; charset=utf-8;width=device-width, initial-scale=1" />
    <title>公积金账号查询</title>
    <link href="Scripts/jquery.mobile-1.4.5/demos/css/themes/default/jquery.mobile-1.4.5.min.css" rel="stylesheet" />
    <link href="Scripts/jquery.mobile-1.4.5/demos/_assets/css/jqm-demos.css" rel="stylesheet" />
    <link href="Scripts/jquery.mobile-1.4.5/demos/favicon.ico" />
    <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Open+Sans:300,400,700">
    <script src="Scripts/jquery.mobile-1.4.5/demos/js/jquery.js"></script>
    <script src="Scripts/jquery.mobile-1.4.5/demos/_assets/js/index.js"></script>
    <script src="Scripts/jquery.mobile-1.4.5/demos/js/jquery.mobile-1.4.5.min.js"></script>
    <style>
        div h4 {
            width: 100%;
            text-align: center;
        }

        label .title {
            color: #3366CC;
            font-weight: bold;
        }

        div input {
            margin-left: 3%;
            width: 50%;
            align-content: center;
        }

        div span {
            margin-left: 2%;
            color: #333333;
            font-weight: bold;
        }

        .divInput {
            margin-left: 4%;
            width: 80%;
        }

        div .btn {
            width: 90%;
        }
    </style>
</head>
<body>
    <form>
        <div role="main">
            <h4>用户注册</h4>
        </div>
        <div>
            <div class="divInput">
                <input type="text" placeholder="请输入用户名" />
            </div>
            <div class="divInput">
                <input type="text" placeholder="请输入公积金账号" style="width: 41%" />
                <input type="button" style="background-color: #CF433F; color: white; font-size: 13px; width: 5%" value="查询" />
            </div>
            <div class="divInput">
                <input type="text" placeholder="请输入身份证号" />
            </div>
            <div class="divInput">
                <input type="text" placeholder="请输入密码" />
            </div>
            <div class="divInput">
                <input type="text" placeholder="请确认密码" />
            </div>
            <div class="divInput">
                <input type="text" placeholder="请输入手机号" />
            </div>
            <div class="divInput">
                <input type="text" placeholder="请输入公积金账号" style="width: 41%" />
                <input type="button" style="background-color: #CF433F; color: white; font-size: 13px; width: 5%" value="获取" />
            </div>
        </div>

        <input type="button" style="width: 90%; height: 10%; background-color: #CF433F; color: white;" value="提 交" />



    </form>
</body>
</html>
