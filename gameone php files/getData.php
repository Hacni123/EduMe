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
    
    $query ="SELECT score_board.score, players.username FROM score_board INNER JOIN players ON score_board.player_id=players.id ORDER by `score` DESC LIMIT 5"; 
    $result = mysqli_query($conn, $query);
  
  if(mysqli_num_rows($result) > 0){
    //show data for each row
    while($row = mysqli_fetch_assoc($result)){
      echo "  ".$row['username']."     "."            -  ".$row['score']."\n";
    }
  }
?>