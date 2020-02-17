using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {
	
	public UserDB LocalDB;
	public string LevelName;
	public Register Reg;
	public static string user = "";
	private string password = "", message = "";
	
	public bool register = false;
	
	private void OnGUI () {
		if (!register) {
			GUILayout.Label (message);
			
			GUI.BeginGroup(new Rect(Screen.width / 2 - 125, Screen.height / 2 - 50,250,100));
			GUI.Box(new Rect(0,0,250,100),"");
			GUI.Label (new Rect(60,10,90,20),"USER ID");
			user = GUI.TextField(new Rect(125,10,120,20),user);
			GUI.Label (new Rect(37,35,90,20),"PASSWORD");
			password = GUI.PasswordField(new Rect(125,35,120,20),password, "*"[0]);
			//membuat tombol
			if (GUI.Button (new Rect(6,68,110,20),"LOGIN")) {
				message = "";
				if (user == "" || password ==""){
					message += "Enter your information \n";
				}
				else {
					WWWForm form = new WWWForm();
					form.AddField("user", user);
					form.AddField("name", name);
					form.AddField("password", password);
					//change http://localhost/datasick/login.php to your own
					WWW w = new WWW("http://localhost/datasick/login.php", form);
					StartCoroutine(login(w));
				}
			}
			if (GUI.Button (new Rect(125,68,120,20),"REGISTER")) {
				register = true;
			}
			GUI.EndGroup();
		}
	}
	
	void Update () {
		if (register) {
			Reg.enabled = true;
		}
		else {
			Reg.enabled = false;
		}
	}
	
	IEnumerator login (WWW w){
		yield return w;
		if (w.error == null){
			if (w.text == "login-SUCCESS"){
				print ("LogedIn");
				message += "LogedIn \n";
				WWWForm form2 = new WWWForm();
				form2.AddField("user", user);
				//change http://localhost/datasick/GetUserData.php to your own
				WWW urlData = new WWW("http://localhost/datasick/GetUserData.php", form2);
				StartCoroutine(GetUserData(urlData));
			}
			else {
				message += w.text;
			}
		}
		else {
			message += "ERROR: " +w.error + "\n";
		}
	}
	
	IEnumerator GetUserData (WWW w2) {
		yield return w2;
		if (w2.error == null) {
			LocalDB.UserID = user;
			LocalDB.NickName = w2.text;
			Application.LoadLevel(LevelName);
		}
		else {
			message += w2.text;
		}
	}

}
