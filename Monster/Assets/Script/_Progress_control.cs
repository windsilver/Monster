using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Progress_control : MonoBehaviour {
	public static string Progress = "";
	public GameObject Panel;

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
				case "Panel_Main_in_Menu": //標題到選單
					SceneManager.LoadScene ("Menu");
					print ("正要切換到下一畫面");
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