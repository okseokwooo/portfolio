<?php include "header.php";?>
<?php include "flex_buy_stock.php";?>
<?php include "flex_sell_stock.php";?>
<?php include "rich_buy_stock.php";?>
<?php include "rich_sell_stock.php";?>
<?php include "normal_buy_stock.php";?>
<?php include "normal_sell_stock.php";?>
<?php include "poor_buy_stock.php";?>
<?php include "poor_sell_stock.php";?>
<?php
    $con = mysqli_connect("localhost", "root", "", "mystock");
    $sql = "select * from company";
    $result = mysqli_query($con, $sql);
    header("Refresh:3; url=my_index.php");
    while( $row = mysqli_fetch_array($result) )
        {
            $num  = $row["num"];        
            $stock_name    = $row["stock_name"];
            $stock_money = $row["stock_money"];
            $stock_num = $row["stock_num"];
?>
            <table>
                    <tr><th><?=$num?></th>
                    <th>이름 :<a href="sell_user_stock.php?stock_name=<?=$stock_name?>"><?=$stock_name?></a></th>
                    <th>가격 : <?=$stock_money?></th> 
                    <th>개수 : <?=$stock_num?></th></tr>
                </table>
<?php
    }
       mysqli_close($con);           
?>