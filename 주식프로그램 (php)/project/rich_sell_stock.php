<?php
        if($buy_stock_num>0){
        $con = mysqli_connect("localhost", "root", "", "mystock");
        $sql = "select * from ai where num>=6 and num<=10 and buy_stock_name!='null' order by rand() limit 1 " ; // 1번 부터 5번까지 주식을 가지고 있는 사람랜덤으로 한명 생성
        $result = mysqli_query($con, $sql);
        $row    = mysqli_fetch_array($result);
        $name = $row["name"];
        $money = $row["money"];
        $buy_stock_num = $row["buy_stock_num"];
        $buy_stock_name = $row["buy_stock_name"];
        $con2 = mysqli_connect("localhost", "root", "", "mystock");
        $sql2 = "select * from company where stock_name='$buy_stock_name' order by rand() limit 1";
        $result2 = mysqli_query($con2, $sql2);
        $row2    = mysqli_fetch_array($result2);
        $stock_money = $row2["stock_money"];
        $stock_name = $row2["stock_name"];
        $sell_money = $stock_money*400;
        $random = rand(1,8); 
        $random2 = rand(1,8);   //ai가 살 확률을 만들기 위해 만든 변수.
        if($random==$random2 && $buy_stock_num>0 ){
            $money += $sell_money;
            $stock_money -= $sell_money/10000;  
            $buy_stock_num -= 400;
            $sql = "update ai set money='$money' , buy_stock_num='$buy_stock_num' where name='$name'";
            $sql2 = "update company set stock_money='$stock_money' where stock_name='$stock_name'";
            mysqli_query($con,$sql);
            mysqli_close($con);
            mysqli_query($con2, $sql2);
            mysqli_close($con2);
            header("Refresh:1; url=rich_sell_stock.php");  //페이지 새로고침
        }
        else{
            header("Refresh:1; url=rich_sell_stock.php"); //페이지 새로고침
        }
        }
?>