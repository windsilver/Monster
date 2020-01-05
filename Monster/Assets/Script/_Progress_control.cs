using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class _Progress_control : MonoBehaviour {
	public static string Progress = "";
	public static int difficulty = 0;
	public GameObject Panel;
	public Text[] Card_Text;
	public GameObject[] Temporary_Gameobject;
	/* 
	Menu					Fight
	0=Grass					Icon
	1=Card
	2=Monster
	3=Name
	4=Icon
	5=HPup
	6=ATKup
	7=Icon_Instantiate
	8=Fight Home
	*/
	public Sprite[] Temporary_Sprite;
	void Start () {
		Progress = "";
		Panel.GetComponent<Animation> ().Play ("Panel_out");
	}

	void Update () {
		if (Progress != "") {
			print (Progress);
			switch (Progress) {
				case "Panel_Main": //開場
					Main_Start.start_in = false;
					break;
				case "Main_start": //點下開始
					Panel.GetComponent<Animation> ().Play ("Panel_in");
					if (File.Exists (Application.persistentDataPath + "/savedata.json")) {
						print ("以偵測到存檔");
						Load ();
					} else {
						print ("正在建立存檔");
						Save (0);
					}
					break;
				case "Panel_Menu": //到選單後
					Menu_Camera.Camera_move = 190;
					break;
				case "Menu_Grow": //點下成長
					Temporary_Gameobject[0].GetComponent<Animation> ().Play ("Menu_Grass_right");
					Temporary_Gameobject[2].GetComponent<SpriteRenderer> ().sprite = Temporary_Sprite[load_data.number - 1];
					Temporary_Gameobject[3].GetComponent<SpriteRenderer> ().sprite = Temporary_Sprite[load_data.number + 2];
					Card_Text[0].text = load_data.level.ToString ();
					Card_Text[1].text = load_data.points.ToString ();
					Card_Text[2].text = load_data.HP_points.ToString () + "/30";
					Card_Text[3].text = load_data.ATK_points.ToString () + "/30";
					Card_Text[4].text = load_data.HP.ToString ();
					Card_Text[5].text = load_data.ATK.ToString ();
					break;
				case "Grass_end": //草地移動完畢時
					Temporary_Gameobject[1].GetComponent<Animation> ().Play ("Menu_Card_down");
					break;
				case "Card_down": //卡片向下完
					Temporary_Gameobject[4].SetActive (true);
					break;
				case "Card_up": //卡片上升完
					Menu_Camera.Camera_move = 190;
					Temporary_Gameobject[4].SetActive (false);
					break;
				case "Menu_Fight": //切到關卡選擇
					Temporary_Gameobject[8].SetActive (true);
					break;
				case "Menu_Difficulty": //選擇關卡後
					Panel.GetComponent<Animation> ().Play ("Panel_in");
					break;
				case "Panel_Fight": //進入戰場後
					Temporary_Gameobject[0].GetComponent<Animation> ().Play ("Fight_Icon_up");
					Card_Text[0].text = load_data.HP.ToString ();
					Card_Text[1].text = load_data.ATK.ToString ();
					Card_Text[2].text = "0";
					break;
			} //switch
			Progress = "";
		}
	}

	/*存儲表*/
	public class data {
		public int number = 1;
		public int level = 1;
		public int points = 2;
		public int HP = 10;
		public int HP_points = 0;
		public int ATK = 5;
		public int ATK_points = 0;
		public int skil_int = 0;
		public bool[] skil1 = { false, false };
		public bool[] skil2 = { false, false };
		public bool[] skil3 = { false, false };
		public bool[] skil4 = { false, false };
		public bool[] skil5 = { false, false };
		public bool[] skil6 = { false, false };
	}
	/*全域讀取暫存*/
	public static data load_data = new data ();
	void Save (int a) {

		string save_string = "";
		if (a == 0) {
			data save0 = new data ();
			save_string = JsonUtility.ToJson (save0);
		} else {
			save_string = JsonUtility.ToJson (load_data);
		}
		StreamWriter file = new StreamWriter (System.IO.Path.Combine (Application.persistentDataPath, "savedata.json"));
		file.Write (save_string);
		file.Close ();
	}

	void Load () {
		StreamReader file = new StreamReader (System.IO.Path.Combine (Application.persistentDataPath, "savedata.json"));
		string load_json = file.ReadToEnd ();
		file.Close ();
		load_data = JsonUtility.FromJson<data> (load_json);
	}

	public void Menu_Home (string a) {
		if (a == "Grow") {
			Temporary_Gameobject[1].GetComponent<Animation> ().Play ("Menu_Card_up");
			Save (1);
		} else {
			Menu_Camera.Camera_move -= 190;
			Temporary_Gameobject[8].SetActive (false);
		}
	}
	public void Menu_add (string name) {
		if (load_data.points > 0) {
			if (name == "HP" && load_data.HP_points < 30) {
				Instantiate (Temporary_Gameobject[5], Temporary_Gameobject[7].transform.position, new Quaternion (0, 0, 0, 0));
				load_data.HP_points += 1;
				load_data.HP += 2;
				Card_Text[2].text = load_data.HP_points.ToString () + "/30";
				Card_Text[4].text = load_data.HP.ToString ();
				load_data.points -= 1;

			}
			if (name == "ATK" && load_data.ATK_points < 30) {
				Instantiate (Temporary_Gameobject[6], Temporary_Gameobject[7].transform.position, new Quaternion (0, 0, 0, 0));
				load_data.ATK_points += 1;
				load_data.ATK += 1;
				Card_Text[3].text = load_data.ATK_points.ToString () + "/30";
				Card_Text[5].text = load_data.ATK.ToString ();
				load_data.points -= 1;
			}
			name = "";
			Card_Text[1].text = load_data.points.ToString ();
		}
	}

}