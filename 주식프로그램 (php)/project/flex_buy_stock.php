<?php
        $con = mysqli_connect("localhost", "root", "", "mystock");
        $sql = "select * from ai where num>=1 and num<=5 order by rand() limit 1" ; // 1번 부터 5번까지 랜덤으로 한명 생성
        $result = mysqli_query($con, $sql);
        $row    = mysqli_fetch_array($result);
        $name = $row["name"];
        $money = $row["money"];
        $buy_stock_num = $row["buy_stock_num"];
        $buy_stock_name = $row["buy_stock_name"];
        $con2 = mysqli_connect("localhost", "root", "", "mystock");
        $sql2 = "select * from company order by rand() limit 1";  //35개의 회사중 한개의 회사 랜덤으로 생성
        $result2 = mysqli_query($con2, $sql2);
        $row2    = mysqli_fetch_array($result2);
        $stock_name = $row2["stock_name"];
        $stock_money = $row2["stock_money"];
        $stock_num = $row2["stock_num"];
        $pay_money = $stock_money * 700;
        $random = rand(1,10); 
        $random2 = rand(1,10);  //ai가 살 확률을 만들기 위해 만든 변수.
        if($random==$random2 && $money >= $pay_money && $stock_num >= 700 ){
            $money -= $pay_money;
            $stock_money += ($stock_money*700)/10000;  
            $stock_num -= 700;
            $buy_stock_num += 700;
            $sql = "update ai set money='$money' , buy_stock_num='$buy_stock_num' , buy_stock_name= '$stock_name' where name='$name'";
            $sql2 = "update company set stock_money='$stock_money' , stock_num='$stock_num' where stock_name='$stock_name'";
            mysqli_query($con, $sql);
            mysqli_query($con2, $sql2);
            //mysqli_close($con);
            //mysqli_close($con2);
            header("Refresh:0; url=flex_buy_stock.php");  //페이지 새로고침
        }
        else{
            header("Refresh:0; url=flex_buy_stock.php"); //페이지 새로고침
        }
?>