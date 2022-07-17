<?php
    $id   = $_POST["id"];
    $pass = $_POST["pass"];
    $name = $_POST["name"];
    $money = 1000000;
              
    $con = mysqli_connect("localhost", "root", "", "mystock");

	$sql = "insert into user_stock(id, pass, name, money) ";
	$sql .= "values('$id', '$pass', '$name', '$money')";

	mysqli_query($con, $sql); 
    mysqli_close($con);     

    echo "
	      <script>
	          location.href = 'my_index.php';
	      </script>
	  ";
?>

   
