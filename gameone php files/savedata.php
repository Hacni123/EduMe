<?php
$servername = "localhost"; 
$server_username = "id15158086_root"; 
$server_password = "I/w+es5cU^0tHVpT"; 
$dbName = "id15158086_edume";

$con = new mysqli($servername, $server_username, $server_password, $dbName);
if ($con->connect_error) {
  die("Connection failed: " . $con->connect_error);
}



$username= $_POST["name"];
$newscore= $_POST["score"];
$coins= $_POST["coins"];
$level= $_POST["level"];
$the_level= $_POST["the_level"];
$health= $_POST["health"];
$time= $_POST["time"];
$time1= $_POST["time1"];
$addition= $_POST["addition1"];
$substraction1= $_POST["substraction1"];
$multiplication1= $_POST["multiplication1"];
$division1= $_POST["division1"];
$addition2= $_POST["addition2"];
$substraction2= $_POST["substraction2"];
$multiplication2= $_POST["multiplication2"];
$division2= $_POST["division2"];

// Create connection

// Check connection

$namecheckquery ="SELECT id,username FROM players WHERE username='".$username."';";


$namecheck=mysqli_query($con, $namecheckquery) or die("2: Name check query failed");

if(mysqli_num_rows($namecheck)!=1)
{
  echo"5: Either no user with name, or more than one";
  exit();
}


$updatequery="UPDATE score_board  JOIN players ON score_board.player_id = players.id SET score_board.score ='$newscore',score_board.coins ='$coins',players.health  ='$health',players.time  ='$time',players.time1  ='$time1',players.level_id ='$level',players.the_level  ='$the_level',players.additionright  ='$addition',players.substractionright  ='$substraction1',players.multiplicationright  ='$multiplication1',players.divisionright  ='$division1',players.additionwrong  ='$addition2',players.substractionwrong  ='$substraction2',players.multiplicationwrong ='$multiplication2',players.divisionwrong ='$division2' WHERE players.username='".$username."';";
mysqli_query($con,$updatequery) or die("7:Save query failed");
echo "0";

?> 