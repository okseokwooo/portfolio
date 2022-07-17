<link rel="stylesheet" type="text/css" href="./css/stock_common.css">
<?php
    session_start();
    if (isset($_SESSION["userid"])) $userid = $_SESSION["userid"];
    else $userid = "";
    if (isset($_SESSION["username"])) $username = $_SESSION["username"];
    else $username = "";
    if (isset($_SESSION["usermoney"])) $usermoney = $_SESSION["usermoney"];
    else $usermoney = "";
    if (isset($_SESSION["buystocknum"])) $buystocknum = $_SESSION["buystocknum"];
    else $buystocknum = "";
    if (isset($_SESSION["buystockname"])) $buystockname = $_SESSION["buystockname"];
    else $buystockname = "";
?>		
<?php
    if(!$userid) {
?>
    <div id ="page">
                <div id = "top_menu">                    
<?php
    } 
else {
        $logged = $username."(".$userid.")님[Money:".$usermoney."] [buy_stock_name: ".$buystockname."] [buy_stock_num: ".$buystocknum."]";
?>       
                <?=$logged?>
    <?php
    }
?>
</div>
        <header>
            <div id="logo">
        <img src="img/logo.png" alt="Logo">
</div>
            <nav>
            <ul>
                <li><a href="stock_member.php">회원 가입</a></li> 
                <li><a href="stock_login_form.php">로그인</a></li>  
                <li><a href="my_index.php">HOME</a></li>
               <li><a href="stock_logout.php">로그아웃</a></li>   
    </ul>
                </nav>
        </header>
        </div>