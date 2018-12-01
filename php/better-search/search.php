<?php
// $a = "a b" ;
//$a = urlencode($a);
// searchdb ( htmlspecialchars(urldecode($a)));

function searchdb($var){
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "test";
try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    // set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    //decode
    $var = htmlspecialchars(urldecode($var));
  //remove white spaces
  $var = preg_replace('/\s+/', ' ', $var);
  //explode search strings into an array
  $arr = explode(" ",$var);
    // prepare sql and bind parameters
    
    if(count($arr) == 0)
    { $stmt = $conn->prepare(
        "SELECT * FROM `mock_data`
        LIMIT 25");
    }
    else{
         $stmt = $conn->prepare(
        "SELECT * FROM `mock_data`".
        buildquery($arr) . "
        LIMIT 25");
    for($x=0; $x < count($arr); $x++ )
        {
          $stmt->bindParam(":var{$x}",appendLikeParm($arr[$x]));
        }
    }
    
    $stmt->execute();
    // set the resulting array to associative

    if($stmt->rowCount() > 0)
    {
    while ($row = $stmt->fetch()){

        echo "<tr><th scope='row'>{$row[0]}</th>
               <td>{$row[1]}</td>
               <td>{$row[2]}</td>
               <td>{$row[3]}</td>
               <td>{$row[4]}</td> </tr>";
    }
  }     
}
catch(PDOException $e)
    {
    echo "Error: " . $e->getMessage();
    }
$conn = null;

}

function buildquery($var)
{
        $result="";
        for($x=0; $x <count($var); $x++ )
        {
            if(count($var)>1){
                if($x == 0)
                    $result .= "WHERE `first_name` LIKE :var{$x} OR `last_name` LIKE :var{$x} ";
               // elseif($x==count($arr))
                else
                    $result .= "OR `first_name` LIKE :var{$x} OR `last_name` LIKE :var{$x} ";    
                }
            else $result .= "WHERE `first_name` LIKE :var{$x} OR `last_name` LIKE :var{$x} ";
        }
        return $result;    
}

function appendLikeParm($parm)
{
    return "%{$parm}%";
}
?>
