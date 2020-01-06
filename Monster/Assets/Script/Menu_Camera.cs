using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Camera : MonoBehaviour {
	public static int Camera_move = 0;
	public static string Camera_button = "";
	void Start () {

	}

	void Update () {
		if (Camera_move != 0) {
			if (Camera_move > 0) {
				transform.localPosition += new Vector3 (0.2f, 0, 0);
				Camera_move -= 2;
			}
			if (Camera_move < 0) {
				transform.localPosition -= new Vector3 (0.2f, 0, 0);
				Camera_move += 2;
			}
		}
		if (Camera_button == "Fight" && Camera_move == 0) {
			_Progress_control.Progress = "Menu_Fight";
			Camera_button = "";
		}
	}
}