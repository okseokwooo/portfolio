<?php
  session_start();
  unset($_SESSION["userid"]);
  unset($_SESSION["username"]);
  unset($_SESSION["usermoney"]);
  unset($_SESSION["buystockname"]);
  unset($_SESSION["buystocknum"]);   
  
  echo("
       <script>
          location.href = 'my_index.php';
         </script>
       ");
?>