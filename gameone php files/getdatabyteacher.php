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
    
    $query ="SELECT score_board.score,players.username,players.time,players.age FROM score_board INNER JOIN players ON score_board.player_id=players.id "; 
    $result = mysqli_query($conn, $query);

    $student_data=array();
    while($row = mysqli_fetch_array($result))
    {
     $student_data[]=$row;  
    }
  
    echo json_encode( $student_data);
?>