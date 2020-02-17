<?PHP

$user = $_POST['user'];

$con = mysql_connect("127.0.0.1","root", "") or ("Cannot connect!" .mysql_error());
if (!$con)
	die('Could not connect: ' . mysql_error());
	
// "mtg" is the name of your database
mysql_select_db("mtg", $con) or die ("could not load the database" . mysql_error());

$sial = mysql_query("SELECT * FROM user WHERE `user` ='".$user."'");


while($row = mysql_fetch_assoc($sial))
{
	$name = $row['name'];
	die($name);
	
}
?>