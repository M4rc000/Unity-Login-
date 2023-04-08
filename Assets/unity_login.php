<?php

$connect = mysqli_connect("localhost", "root", "", "unity");

if(!$connect){
    die("Cannot connect !");
}

$user = $_POST['unity_user'];
$pass = $_POST['unity_pass'];
$sql = "SELECT * FROM tbl_login WHERE username = '$user' AND pass = '$pass'";
$result = mysqli_query($connect, $sql);
$row = mysqli_fetch_row($result);

if($row){
    echo $row[1];
}
else{
    echo "What the **** are you doing";
}
?>