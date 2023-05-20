<?php
try{
$connection = new PDO('mysql:host=localhost,dbname=lilian_ppe_marchand_layrac_adapt','root','');
$connection ->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
echo "yes connected";
}catch(PDOException $exe){
echo $exe ->getMessage();
die("could not connect");
}

?>