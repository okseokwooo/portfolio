<!DOCTYPE html>
<html>
<head> 
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="./css/stock_member.css">
<link rel="stylesheet" type="text/css" href="./css/stock_common.css">
<title>회원가입</title>
<script>
   function check_input()
   {
      if (!document.stock_member.id.value) {
          alert("아이디를 입력하세요!");    
          document.stock_member.id.focus();
          return;
      }

      if (!document.stock_member.pass.value) {
          alert("비밀번호를 입력하세요!");    
          document.stock_member.pass.focus();
          return;
      }

      if (!document.stock_member.pass_confirm.value) {
          alert("비밀번호확인을 입력하세요!");    
          document.stock_member.pass_confirm.focus();
          return;
      }

      if (!document.stock_member.name.value) {
          alert("이름을 입력하세요!");    
          document.stock_member.name.focus();
          return;
      }
      if (document.stock_member.pass.value != 
            document.stock_member.pass_confirm.value) {
          alert("비밀번호가 일치하지 않습니다.\n다시 입력해 주세요!");
          document.stock_member.pass.focus();
          document.stock_member.pass.select();
          return;
      }

      document.stock_member.submit();
   }

   function reset_form() {
      document.stock_member.id.value = "";  
      document.stock_member.pass.value = "";
      document.stock_member.pass_confirm.value = "";
      document.stock_member.name.value = "";
      document.stock_member.id.focus();
      return;
   }

   function check_id() {
     window.open("stock_member_check_id.php?id=" + document.stock_member.id.value,
         "IDcheck",
          "left=700,top=300,width=350,height=200,scrollbars=no,resizable=yes");
   }
</script>
</head>
<body> 
	<section>
        <div id="main_content">
      		<div id="join_box">
          	<form  name="stock_member" method="post" action="user_insert.php">
			    <h2>회원 가입</h2>
    		    	<div class="form id">
				        <div class="col1">아이디</div>
				        <div class="col2">
							<input type="text" name="id">
				        </div>
                        <div class="col3">
				        	<a href="#"><img src="./img/check_id.gif" 
				        		onclick="check_id()"></a>
				        </div>
                </div>
			       	<div class="clear"></div>

			       	<div class="form">
				        <div class="col1">비밀번호</div>
				        <div class="col2">
							<input type="password" name="pass">
				        </div>                 
			       	</div>
			       	<div class="clear"></div>
			       	<div class="form">
				        <div class="col1">비밀번호 확인</div>
				        <div class="col2">
							<input type="password" name="pass_confirm">
				        </div>                 
			       	</div>
			       	<div class="clear"></div>
			       	<div class="form">
				        <div class="col1">이름</div>
				        <div class="col2">
							<input type="text" name="name">
				        </div>                 
			       	</div>
                    <div class="clear"></div>
			       	<div class="bottom_line"> </div>
                    <div>
				        	<img src="./img/button_save.gif" style="cursor:pointer"  onclick="check_input()">&nbsp;
                  		<img id="reset_button" style="cursor:pointer" src="./img/button_reset.gif"
                  			onclick="reset_form()">
				        </div>
           	</form>
        	</div> 
        </div> 
	</section>
</body>
</html>

