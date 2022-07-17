<?php include "header.php";?>
<?php
  $stock_name = $_SESSION["temp"];
  $con = mysqli_connect("localhost", "root", "", "mystock");
  $sql = "select * from company where stock_name='$stock_name'";
  $result = mysqli_query($con, $sql);
  $row = mysqli_fetch_array($result);
  $num  = $row["num"];        
  $stock_money = $row["stock_money"];
  $stock_num = $row["stock_num"];
  $con2 = mysqli_connect("localhost", "root", "", "mystock");
  $sql2 = "select * from user_stock where id='$userid'";
  $result2 = mysqli_query($con2, $sql2);
  $row2 = mysqli_fetch_array($result2);
  $buy_stock_num = $_GET["user_stock_num"];
  $user_stock_num = $row2["buy_stock_num"];
  $price = $buy_stock_num * $stock_money;
  if($usermoney < $price){
       echo("<script>
				alert('돈이 부족합니다!');
				history.go(-1);
				</script>
			");
		exit;
  }
    else{
        $stock_money += $price / 10000;
        $user_stock_num += $buy_stock_num;
        $stock_num -= $buy_stock_num;
        $usermoney -= $price;
        echo("
              <script>
                location.href = 'my_index.php';
              </script>
            ");
        $_SESSION["usermoney"] = $usermoney;
        $_SESSION["buystockname"] = $stock_name;
        $_SESSION["buystocknum"] = $user_stock_num;
        $sql = "update company set stock_money='$stock_money' , stock_num='$stock_num' where stock_name='$stock_name'";
        $sql2 = "update user_stock set money = '$usermoney' , buy_stock_name='$stock_name' , buy_stock_num='$user_stock_num' where id='$userid'";
        mysqli_query($con,$sql);
        mysqli_close($con);
        mysqli_query($con2, $sql2);
        mysqli_close($con2);
        $_SESSION["temp"]="";
}
?>