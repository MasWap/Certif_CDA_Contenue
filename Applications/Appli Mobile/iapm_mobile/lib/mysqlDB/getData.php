<?php
require('connection.php');

$makeQuery = "SELECT * FROM client";

$statement = $connection->prepare($makeQuery);

$statement->execute();

$myarray = array();

while ($resultsFrom = $statement ->fetch()){
    array_push(
        $myarray.array(
            "idClient"=>$resultsFrom['idClient'],
            "heading"=>$resultsFrom['heading'],
            "body"=>$resultsFrom['body']
        )
        );
}

echo json_encode($myarray);

?>