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
$x= $_POST["x"];
$y= $_POST["y"];
$z= $_POST["z"];


// Create connection

// Check connection

$namecheckquery = "SELECT  username  FROM players WHERE username= '".$username."'; ";
$namecheck=mysqli_query($con, $namecheckquery) or die("2: Name check query failed");

if(mysqli_num_rows($namecheck)!=1)
{
  echo"5: Either no user with name, or more than one";
  exit();
}
$updatequery="UPDATE players SET players.x ='$x', players.y ='$y',players.z ='$z' WHERE players.username='".$username."';";



mysqli_query($con,$updatequery) or die("7:Save query failed");
echo "0";

?> 