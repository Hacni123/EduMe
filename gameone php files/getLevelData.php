<?php
 header("Access-Control-Allow-Credentials: true");
 header('Access-Control-Allow-Origin: *');
 header('Access-Control-Allow-Methods: POST, GET, OPTIONS');
 header('Access-Control-Allow-Headers: Accept, X-Access-Token, X-Application-Name, X-Request-Sent-Time');
 $servername = "localhost"; 
 $server_username = "id15158086_root"; 
 $server_password = "I/w+es5cU^0tHVpT"; 
 $dbName = "id15158086_edume";
  //make connection
  $conn = new mysqli($servername, $server_username, $server_password, $dbName);
  if(!$conn){
    die("Connection failed: " . mysqli_connect_error());
  }
    
    $query ="SELECT * FROM levels"; 
    $result = mysqli_query($conn, $query);
  
  if(mysqli_num_rows($result) > 0){
    //show data for each row
    while($row = mysqli_fetch_assoc($result)){
      echo "  ".$row['level_name']."\n";
      echo "  ".$row['level_desc']."\n";
      echo "\n";
    }
  }

  
  //$namecheckquery2 = "SELECT * FROM levels"; 

 // $namecheck2=mysqli_query($conn, $namecheckquery2) or die("2: Name check query failed");
 // $existinginfo=mysqli_fetch_assoc($namecheck2);
 // echo "0\t".$existinginfo["level_name"]."\t".$existinginfo["level_desc"].$existinginfo["level_name"]."\t".$existinginfo["level_desc"];
?>