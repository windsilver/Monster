using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Camera : MonoBehaviour {
	public static float Camera_move = 0;
	public static string Camera_button = "";
	void Start () {
		Camera_move = 0;
	}

	void Update () {
		if (Camera_move != 0) {
			if (Camera_move > 0) {
				transform.localPosition += new Vector3 (0.25f, 0, 0);
				Camera_move -= 2.5f;
			}
			if (Camera_move < 0) {
				transform.localPosition -= new Vector3 (0.25f, 0, 0);
				Camera_move += 2.5f;
			}
		}
		if (Camera_button == "Fight" && Camera_move == 0) {
			_Progress_control.Progress = "Menu_Fight";
			Camera_button = "";
		}
	}
}