<?PHP

$user = $_POST['user'];
$pass = $_POST['password'];
//change this to your own
$con = mysql_connect("127.0.0.1","root", "") or ("Cannot connect!" .mysql_error());
if (!$con)
	die('Could not connect: ' . mysql_error());
	
// "mtg" is the name of your database
mysql_select_db("mtg", $con) or die ("could not load the database" . mysql_error());

$check = mysql_query("SELECT * FROM user WHERE `user` ='".$user."'");
$numrows = mysql_num_rows($check);
if ($numrows == 0)
{
	die ("Username does not exist \n");
}
else
{
	$pass = md5($pass);
	while($row = mysql_fetch_assoc($check))
	{
		if ($pass == $row['pass'])
			die("login-SUCCESS");
		else
			die("Password does not match :v \n");
			//die($pass);
	}
}

?>