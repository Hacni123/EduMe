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
        $usernameclean= filter_var($username, FILTER_SANITIZE_STRING, FILTER_FLAG_STRIP_LOW |  FILTER_FLAG_STRIP_HIGH);
      $password = $_POST["password"];


// Create connection

// Check connection

$namecheckquery = "SELECT  name,hash,salt FROM Teacher WHERE Teacher.name= '".$usernameclean."'; ";;
$namecheck=mysqli_query($con, $namecheckquery) or die("2: Name check query failed");

if(mysqli_num_rows($namecheck)!=1)
{
  echo"Either no user with name, or more than one";
  exit();
}

$existinginfo1=mysqli_fetch_assoc($namecheck);
$salt = $existinginfo1["salt"];
$hash = $existinginfo1["hash"];

$loginhash=crypt($password,$salt);
if($hash!=$loginhash)
{
    echo "6: Incorrect password";
    exit();
}

echo("0");
    
     



?> 