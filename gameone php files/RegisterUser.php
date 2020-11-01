<?php
$servername = "localhost"; 
$server_username = "id15158086_root"; 
$server_password = "I/w+es5cU^0tHVpT"; 
$dbName = "id15158086_edume";
$con = new mysqli($servername, $server_username, $server_password, $dbName);
if ($con->connect_error) {
  die("Connection failed: " . $con->connect_error);
}


 $username = mysqli_real_escape_string($con,$_POST["name"]);
 //$password = mysqli_real_escape_string($con,$_POST["password"]);
 $age = mysqli_real_escape_string($con,$_POST["age"]);

// Create connection

// Check connection


$namecheckquery = "SELECT  username  FROM players WHERE username= '".$username."'; ";
$namecheck=mysqli_query($con, $namecheckquery) or die("2: Name check query failed");

if(mysqli_num_rows($namecheck)>0)
{
  echo"3: Name already exists";
  exit();
}

//$salt = "\$5\$rounds=5000\$"."steamedhams".$username."\$";
//$hash=crypt($password,$salt);
$insertuserquery="INSERT INTO players (username,age) VALUES ('".$username."','".$age."');";
$query=mysqli_query($con,$insertuserquery) or die("4:Insert player query failed");

if($query==1)
{
  $insertuserquery2="INSERT INTO login (player_id,username)
SELECT id,username FROM players WHERE players.username= '".$username."'; ";
$query2=mysqli_query($con,$insertuserquery2) or die("6:Insert login2 query failed");
  
  
}

$insertuserquery3="INSERT INTO score_board (player_id)
SELECT 	id FROM  players WHERE  players.username= '".$username."'; ";

mysqli_query($con,$insertuserquery3) or die("6:Insert login7 query failed");
  echo("0");
?> 