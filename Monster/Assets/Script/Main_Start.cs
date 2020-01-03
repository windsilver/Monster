using UnityEngine;

public class Main_Start : MonoBehaviour {
	bool mouse_down = false;
	public static bool start_in = true;
	public GameObject Image;
	void OnMouseOver () {
		if (!start_in) {
			if (Input.GetMouseButtonDown (0)) {
				Image.transform.localScale = new Vector3 (0.8f, 0.8f, 1);
				mouse_down = true;
			} else if (Input.GetMouseButtonUp (0) && mouse_down) {
				start_in = true;
				mouse_down = false;
				Image.transform.localScale = new Vector3 (1f, 1f, 1);
				_Progress_control.Progress = "Main_start";
			}
		}
	}

	void OnMouseEnter () {
		if (!start_in) {
			Image.transform.localScale = new Vector3 (0.9f, 0.9f, 1);
		}
	}

	void OnMouseExit () {
		if (!start_in) {
			Image.transform.localScale = new Vector3 (1f, 1f, 1);
			mouse_down = false;
		}
	}

}