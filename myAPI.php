<?php 
$conn = mysqli_connect('localhost',"root","","your_database_name");
if ($_SERVER["REQUEST_METHOD"] === 'POST')
{
    $first_name = $_REQUEST["name"];
    $last_name = $_REQUEST["price"];
    $phone_no = $_REQUEST["description"];
    
   
        $query = "INSERT INTO products_api (`name`,`price`,`description`)   VALUES('$first_name','$last_name','$phone_no')";
    $result = $conn->query($query);
    if ($result == 1)
    {
        $data["message"] = "data saved successfully";
        $data["status"] = "Ok";
    }
    else
    {
        $data["message"] = "data not saved successfully";
        $data["status"] = "error";    
    }
   
    
    
}
else
{
    $data["message"] = "Format not supported";
    $data["status"] = "error";    
}
    echo json_encode($data);
