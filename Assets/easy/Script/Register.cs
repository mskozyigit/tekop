using UnityEngine;
using System.Collections;

public class Register : MonoBehaviour {

	public UserDB LocalDB;
	public static string user = "";
	public Login Log;
	private string password = "", message = "", email = "", nick = "";
	
	private bool register = false;
	
	void OnGUI () {
		//if the register is true then draw the gui
		if (register) {
			GUILayout.Label (message);
			
			GUI.BeginGroup(new Rect(Screen.width / 2 - 125, Screen.height / 2 - 80,250,160));
			GUI.Box(new Rect(0,0,250,160),"");
			GUI.Label (new Rect(60,10,90,20),"USER ID");
			user = GUI.TextField(new Rect(125,10,120,20),user);
			GUI.Label (new Rect(37,35,90,20),"PASSWORD");
			password = GUI.PasswordField(new Rect(125,35,120,20),password, "*"[0]);
			GUI.Label (new Rect(72, 68, 90, 20),"EMAIL");
			email = GUI.TextField(new Rect(125, 68, 120, 20),email);
			GUI.Label (new Rect (39, 93, 90,20),"NICK NAME");
			nick = GUI.TextField(new Rect(125, 93, 120, 20),nick,8);
			
			//Make button
			if (GUI.Button (new Rect(6,128,110,20),"BACK")) {
				Log.register = false;
			}
			if (GUI.Button (new Rect (125, 128, 120,20),"REGISTER")) {
				message = "";
				if (user == "" || password == "" || email == "" || nick == "") {
					message += "Enter your information \n";
				}
				else {
					WWWForm registerForm = new WWWForm();
					registerForm.AddField("user",user);
					registerForm.AddField("password", password);
					registerForm.AddField("email", email);
					registerForm.AddField("nick", nick);
					
					//change to your Register.php url
					WWW Reg = new WWW("http://localhost/datasick/Register.php", registerForm);
					StartCoroutine(Registering(Reg));
				}
			}
			GUI.EndGroup();
		}
	}
	
	void Update () {
		register = Log.register;
	}
	
	IEnumerator Registering (WWW w) {
		yield return w;
		message = w.text;
	}
}
