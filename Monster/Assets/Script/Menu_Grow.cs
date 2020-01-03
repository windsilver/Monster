using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Grow : MonoBehaviour {

	bool mouse_down = false;
	public GameObject Image;
	void OnMouseOver () {
		if (Menu_Camera.Camera_move == 0) {
			if (Input.GetMouseButtonDown (0)) {
				Image.transform.localScale = new Vector3 (0.8f, 0.8f, 1);
				mouse_down = true;
			} else if (Input.GetMouseButtonUp (0) && mouse_down) {
				Menu_Camera.Camera_move = -190;
				mouse_down = false;
				Image.transform.localScale = new Vector3 (1f, 1f, 1);
				_Progress_control.Progress = "Menu_Grow";
			}
		}
	}

	void OnMouseEnter () {
		if (Menu_Camera.Camera_move == 0) {
			Image.transform.localScale = new Vector3 (0.9f, 0.9f, 1);
		}
	}

	void OnMouseExit () {
		if (Menu_Camera.Camera_move == 0) {
			Image.transform.localScale = new Vector3 (1f, 1f, 1);
			mouse_down = false;
		}
	}
}