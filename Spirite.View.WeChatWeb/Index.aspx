<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Spirite.View.WeChatWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" http-equiv="Content-Type" content="text/html; charset=utf-8;width=device-width, initial-scale=1" />
    <title>公积金账号查询</title>
    <link href="Scripts/jquery.mobile-1.4.5/demos/css/themes/default/jquery.mobile-1.4.5.min.css" rel="stylesheet" />
    <link href="Scripts/jquery.mobile-1.4.5/demos/_assets/css/jqm-demos.css" rel="stylesheet" />
    <link href="Scripts/jquery.mobile-1.4.5/demos/favicon.ico" rel="icon" />
    <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Open+Sans:300,400,700" />
    <script src="Scripts/jquery.mobile-1.4.5/demos/js/jquery.js"></script>
    <script src="Scripts/jquery.mobile-1.4.5/demos/_assets/js/index.js"></script>
    <script src="Scripts/jquery.mobile-1.4.5/demos/js/jquery.mobile-1.4.5.min.js"></script>
    <style>
        div h4
        {
            width: 100%;
            text-align: center;
        }

        label .title
        {
            color: #3366CC;
            font-weight: bold;
        }

        div input
        {
            margin-left: 3%;
            width: 50%;
            align-content: center;
        }

        div span
        {
            margin-left: 2%;
            color: #333333;
            font-weight: bold;
        }

        .divInput
        {
            margin-left: 4%;
            width: 80%;
        }
        div .btn
        {   
            width: 90%;
        }
    </style>
</head>
<body>
    <form>
        <div role="main">
            <h4>个人公积金账号查询</h4>
        </div>
        <div>
            <div><span>姓名</span>(输入您的姓名)</div>
            <div class="divInput">
                <input type="text" placeholder="输入您的姓名" />
            </div>
            <div><span>第三方认证机构</span>(选择需认证的机构名称)</div>
            <div class="divInput">
                <input type="text" placeholder="选择需认证的机构名称" />
            </div>
            <div><span>身份证</span>(输入个人身份证号码)</div>
            <div class="divInput">
                <input type="text" placeholder="输入个人身份证号码" />
            </div>
            <div><span>手机号码</span>(输入与该机构绑定和实名认证的手机号)</div>
            <div class="divInput">
                <input type="text" placeholder="输入与该机构绑定和实名认证的手机号" />
            </div>
        </div>
        <div class="btn"><a href="#" class="ui-btn ui-corner-all" style="background-color: #CF433F; color: white;">信息校验</a></div>
        <img class="popphoto" src="Images/erweimalogo.jpg" alt="Paris, France" style="width:90%;height:10%;" />
    </form>
</body>
</html>
