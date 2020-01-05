using UnityEngine;

public class Menu_Difficulty : MonoBehaviour {
	bool mouse_down = false;
	public GameObject Protal;
	void OnMouseOver () {
		if (Menu_Camera.Camera_move == 0) {
			if (Input.GetMouseButtonDown (0)) {
				Protal.transform.localScale = new Vector3 (0.8f, 0.8f, 1);
				mouse_down = true;
			} else if (Input.GetMouseButtonUp (0) && mouse_down) {
				mouse_down = false;
				Protal.transform.localScale = new Vector3 (1f, 1f, 1);
				Menu_Camera.Camera_move += 190;
				_Progress_control.Progress = "Menu_Difficulty";
				switch (this.name) {
					case "Easy":
						_Progress_control.difficulty = 1;
						break;
					case "Normal":
						_Progress_control.difficulty = 2;
						break;
					case "Hard":
						_Progress_control.difficulty = 3;
						break;
					case "VeryHard":
						_Progress_control.difficulty = 4;
						break;

				}
			}
		}
	}

	void OnMouseEnter () {
		if (Menu_Camera.Camera_move == 0) {
			Protal.transform.localScale = new Vector3 (0.9f, 0.9f, 1);
		}
	}

	void OnMouseExit () {
		if (Menu_Camera.Camera_move == 0) {
			Protal.transform.localScale = new Vector3 (1f, 1f, 1);
			mouse_down = false;
		}
	}
}