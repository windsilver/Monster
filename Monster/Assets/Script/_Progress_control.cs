using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Progress_control : MonoBehaviour {
	public static string Progress = "";
	public GameObject Panel;
	public GameObject[] Temporary_Gameobject;

	void Start () {
		Progress = "";
		Panel.GetComponent<Animation> ().Play ("Panel_out");
	}

	void Update () {
		if (Progress != "") {
			switch (Progress) {
				case "Panel_Main": //開場
					Main_Start.start_in = false;
					break;
				case "Main_start": //點下開始
					Panel.GetComponent<Animation> ().Play ("Panel_in");
					break;
				case "Panel_Menu": //到選單後
					Menu_Camera.Camera_move = 190;
					break;
				case "Menu_Grow": //點下成長
					Temporary_Gameobject[0].GetComponent<Animation> ().Play ("Menu_Grass_right");
					break;
				case "Grass_end": //草地移動完畢時
					Temporary_Gameobject[1].GetComponent<Animation> ().Play ("Menu_Card_down");
					break;
			} //switch
			Progress = "";
		}
	}

	void Save_data () {

	}

	void Load_data () {

	}

}