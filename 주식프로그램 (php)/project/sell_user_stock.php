<?php include "header.php";?>
<?php
	if (!$userid)
	{
		echo("<script>
				alert('로그인 후 이용해주세요!');
				history.go(-1);
				</script>
			");
		exit;
	}
    $stock_name = $_GET["stock_name"];
    $con = mysqli_connect("localhost", "root", "", "mystock");
    $sql = "select * from company where stock_name='$stock_name'";
    $result = mysqli_query($con, $sql);
    $row = mysqli_fetch_array($result);
    $num  = $row["num"];        
    $stock_name = $row["stock_name"];
    $stock_money = $row["stock_money"];
    $stock_num = $row["stock_num"];
    $con2 = mysqli_connect("localhost", "root", "", "mystock");
    $sql2 = "select * from user_stock where id='$userid'";
?>
<script>
    function user_buy()
{
    <?php
        $_SESSION["temp2"]=$stock_name; 
    ?>
    var buy_stock_num = document.user.user_stock_num2.value;
    document.user.submit();
}
</script>
<script>
    function user_sell()
{
    <?php
        $_SESSION["temp"]=$stock_name; 
    ?>
    var sell_stock_num = document.user2.user_stock_num.value;
    document.user2.submit();
}
</script>
<li>
                    <span><?=$num?></span>
                <span>이름 : <?=$stock_name?></span>
                    <span>가격 : <?=$stock_money?></span>
                    <span>개수 : <?=$stock_num?></span>
                </li>
<form name = "user" method="get" action="user_buy_stock.php">
                <input type="button" value="구매" onclick="user_buy()" href="user_buy_stock.php">
                <input type="number" name="user_stock_num2" min="1" max="5000" step="1">
    </form>
<form name = "user2" method="get" action="user_sell_stock.php">
                <input type="button" value="판매" onclick="user_sell()"  href="user_sell_stock.php">
                <input type="number" name="user_stock_num" min="1" max="5000" step="1">
    </form>