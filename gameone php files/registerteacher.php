<?php
$servername = "localhost"; 
$server_username = "id15158086_root"; 
$server_password = "I/w+es5cU^0tHVpT"; 
$dbName = "id15158086_edume";
 
$con = new mysqli($servername, $server_username, $server_password, $dbName);
if ($con->connect_error) {
  die("Connection failed: " . $con->connect_error);
}

$username = $_POST["name"];
$password = $_POST["password"];

$namecheckquery = "SELECT  name  FROM Teacher WHERE name = '".$username."'; ";
$namecheck=mysqli_query($con, $namecheckquery) or die("2: Name check query failed");

if(mysqli_num_rows($namecheck)>0)
{
  echo"3: Name already exists";
  exit();
}

$salt = "\$5\$rounds=5000\$"."steamedhams".$username."\$";
$hash=crypt($password,$salt);
$insertuserquery="INSERT INTO Teacher (name,hash,salt) VALUES ('".$username."','".$hash."','".$salt."');";
mysqli_query($con,$insertuserquery) or die("4:Insert player query failed");

echo("0");
?> 