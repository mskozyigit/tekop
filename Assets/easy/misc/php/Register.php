<?PHP

$user = $_POST['user'];
$password = $_POST['password'];
$email = $_POST['email'];
$nick = $_POST['nick'];

//change this to your own
$con = mysql_connect("127.0.0.1","root", "") or ("Cannot connect!" .mysql_error());
if (!$con)
	die('Could not connect: ' . mysql_error());
	
// "mtg" is the name of your database
mysql_select_db("mtg", $con) or die ("could not load the database" . mysql_error());

$password = md5($password);
$ins = mysql_query("INSERT INTO `user`(`user`, `name`, `pass`, `email`) VALUES ('".$user."','".$nick."','".$password."','".$email."')");
if (!$ins)
	die('Could not register, make sure no data is same: ' . mysql_error());
die('Register succes');
?>