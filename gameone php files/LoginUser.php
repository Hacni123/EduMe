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
      //$password = $_POST["password"];


// Create connection

// Check connection


$namecheckquery = "SELECT  login.username FROM login INNER JOIN players ON login.player_id=players.id WHERE players.username= '".$usernameclean."'; ";;
$namecheck=mysqli_query($con, $namecheckquery) or die("2: Name check query failed");

if(mysqli_num_rows($namecheck)!=1)
{
  echo"Either no user with name, or more than one";
  exit();
}

//$existinginfo1=mysqli_fetch_assoc($namecheck);
//$salt = $existinginfo1["salt"];
//$hash = $existinginfo1["hash"];

//$loginhash=crypt($password,$salt);
//if($hash!=$loginhash)
//{
    //echo "6: Incorrect password";
    //exit();
//}
$namecheckquery2 = "SELECT score_board.score,score_board.score1,score_board.score2,score_board.score3,score_board.score4,score_board.coins,score_board.diamands,score_board.coins2,score_board.diamands2,score_board.stars2, players.x_pos1, players.y_pos1,players.z_pos1, players.x_pos2, players.y_pos2,players.z_pos2,players.level_id,players.the_level,players.health,players.health2,players.time,players.time1 FROM score_board INNER JOIN players ON score_board.player_id=players.id WHERE players.username= '".$username."'; ";;

$namecheck2=mysqli_query($con, $namecheckquery2) or die("2: Name check query failed");
$existinginfo=mysqli_fetch_assoc($namecheck2);
echo "0\t".$existinginfo["score"]."\t".$existinginfo["score1"]."\t".$existinginfo["score2"]."\t".$existinginfo["score3"]."\t".$existinginfo["score4"]."\t".$existinginfo["coins"]."\t".$existinginfo["diamands"]."\t".$existinginfo["coins2"]."\t".$existinginfo["diamands2"]."\t".$existinginfo["stars2"]."\t".$existinginfo["x_pos1"]."\t".$existinginfo["y_pos1"]."\t".$existinginfo["z_pos1"]."\t".$existinginfo["x_pos2"]."\t".$existinginfo["y_pos2"]."\t".$existinginfo["z_pos2"]."\t".$existinginfo["level_id"]."\t".$existinginfo["the_level"]."\t".$existinginfo["health"]."\t".$existinginfo["health2"]."\t".$existinginfo["time"]."\t".$existinginfo["time1"];
    
    
     



?> 