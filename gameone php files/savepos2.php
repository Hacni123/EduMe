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
$x2= $_POST["x"];
$y2= $_POST["y"];
$z2= $_POST["z"];


// Create connection

// Check connection

$namecheckquery = "SELECT  username  FROM players WHERE username= '".$username."'; ";
$namecheck=mysqli_query($con, $namecheckquery) or die("2: Name check query failed");

if(mysqli_num_rows($namecheck)!=1)
{
  echo"5: Either no user with name, or more than one";
  exit();
}
$updatequery="UPDATE players SET players.x_pos2 ='$x2', players.y_pos2 ='$y2',players.z_pos2 ='$z2' WHERE players.username='".$username."';";



mysqli_query($con,$updatequery) or die("7:Save query failed");
echo "0";

?> 