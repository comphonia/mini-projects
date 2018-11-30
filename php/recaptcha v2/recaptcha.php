<?php
if(isset($_POST['g-recaptcha-response']) && !empty($_POST['g-recaptcha-response'])){
        //your site secret key
        $secret = '6LeIxAcTAAAAAGG-vFI1TnRWxMZNFuojJ4WifJWe';
        //get verify response data
        $verifyResponse = file_get_contents('https://www.google.com/recaptcha/api/siteverify?secret='.$secret.'&response='.$_POST['g-recaptcha-response']);
        //$responseData = json_encode($verifyResponse);
        
        $responseData = json_decode($verifyResponse);
      //  echo json_encode($responseData->success);

        if(json_encode($responseData->success)){
            //Success, do stuff here
            echo "Success! Hello ". $_POST["firstname"];
            
        } 
    } else{
		echo "Could not verify captcha";
	}

?>

 <html>
  <head>
  <!-- client side script in the head -->
     <script src="https://www.google.com/recaptcha/api.js" async defer> </script>
  </head>
  <body>

    <form action="" method="POST">
      First name:<br>
  <input type="text" name="firstname">
  <br><br>
    <!-- client side div in the form -->
      <div class="g-recaptcha" data-sitekey="6LeIxAcTAAAAAJcZVRqyHh71UMIEGNQ_MXjiZKhI"></div>
      <br/>
      <input type="submit" value="Submit">
    </form>
    
    <h2>Recaptcha Testing</h2>
       <p>Submit without recaptcha for fail results</p>
  </body>
</html> 