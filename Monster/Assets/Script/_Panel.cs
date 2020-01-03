using UnityEngine;
using UnityEngine.SceneManagement;

public class _Panel : MonoBehaviour {
	public bool Panel_out = false;
	public bool Panel_in = false;

	void Update () {
		if (Panel_out) {
			switch (SceneManager.GetActiveScene ().name) {
				case "Main":
					_Progress_control.Progress = "Panel_Main";
					break;
			}

			Panel_out = false;
		}

		if (Panel_in) {
			switch (SceneManager.GetActiveScene ().name) {
				case "Main":
					_Progress_control.Progress = "Panel_Main_in_Menu";
					break;
			}
			Panel_in = false;
		}
	}
}