using UnityEngine;
using UnityEngine.SceneManagement;

public class _Panel : MonoBehaviour {
	public bool Panel_out = false;
	public bool Panel_in = false;
	//public static string Panel_switch = "";
	void Update () {
		if (Panel_out) {
			switch (SceneManager.GetActiveScene ().name) {
				case "Main":
					_Progress_control.Progress = "Panel_Main";
					break;
				case "Menu":
					_Progress_control.Progress = "Panel_Menu";
					break;
				case "Fight":
					_Progress_control.Progress = "Panel_Fight";
					break;
			}

			Panel_out = false;
		}

		if (Panel_in) {
			switch (SceneManager.GetActiveScene ().name) {
				case "Main":
					SceneManager.LoadScene ("Menu");
					break;
				case "Menu":
					SceneManager.LoadScene ("Fight");
					break;
				case "Fight":
					SceneManager.LoadScene ("Menu");
					break;
			}
			Panel_in = false;
		}
	}
}