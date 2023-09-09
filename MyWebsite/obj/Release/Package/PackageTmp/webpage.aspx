<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webpage.aspx.cs" Inherits="MyWebsite.webpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>

        *{
            font-family: Arial, Helvetica, sans-serif;
            margin:0px;
            padding:0px;
            text-decoration: none;
            box-sizing: border-box;
        }

        body{
            min-height: 100vh;
            background: gray;
        }

        form{
            background: rgb(32,32,32);
            height: 500px;
            width: 350px;
            padding-left: 35px;
            padding-right: 35px;
            padding-top :50px;
            position:absolute;
            left:50%;
            top:50%;
            transform: translate(-50%,-50%);
        }

        h1{
            text-align: center;
            margin-bottom: 45px;
            color:rgb(199, 170, 41);
            font-size: 25px;
        }

        .tb_input{
    
            border-bottom: 2px solid white;
            position: relative;
            margin:35px 0;
            width: 100%;
        }

        .tb_input input{
   
            background: none;
            border: none;
            outline:none;
            width:100%;
            color:white;
            height: 35px;
            font-size:20px;
        }

        .btn_submit{

            background:rgb(206,206,206);
            color:rgb(32,32,32);
            height: 45px;
            width:100%;
            border:none;
            outline:none;
            font-size: 16px;
            transition: 0.15s;
        }

        .btn_submit:hover{
            opacity: 0.7;
            font-size: 17px;
        }

        .btn_submit:active{
            opacity: 0.5;
            font-size: 17px;

        }

        .lbl_sign-up 
        {
            color:white;
            margin-top: 50px;
            text-align: center;
        }

        .lbl_sign-up a
        {
            color:rgb(199, 170, 41);
        }


    </style>
</head>
<body>



    <form id="form1" runat="server">

         <h1>Login</h1>
            <div class="tb_input">
                <input type="text"placeholder="Username">
            </div>
            <div class="tb_input">
                <input type="password" placeholder="Password">
            </div>
            <input type="submit" value="Login" class="btn_submit">

            <div class="lbl_sign-up">
                Don't have an account ?
                </br>
                <a href="#">Sign up</a>
            </div>

        
    </form>
</body>
</html>
