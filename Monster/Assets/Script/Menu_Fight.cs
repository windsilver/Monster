﻿using UnityEngine;

public class Menu_Fight : MonoBehaviour {
	bool mouse_down = false;
	public GameObject Image;
	void OnMouseOver () {
		if (Menu_Camera.Camera_move == 0) {
			if (Input.GetMouseButtonDown (0)) {
				Image.transform.localScale = new Vector3 (0.8f, 0.8f, 1);
				mouse_down = true;
			} else if (Input.GetMouseButtonUp (0) && mouse_down) {
				Menu_Camera.Camera_move = +190;
				mouse_down = false;
				Image.transform.localScale = new Vector3 (1f, 1f, 1);
				Menu_Camera.Camera_button = "Fight";
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