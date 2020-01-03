using UnityEngine;

public class _Panel : MonoBehaviour {
	public bool Panel_out = false;
	public bool Panel_in = false;

	void Update () {
		if (Panel_out) {
			_Progress_control.Progress = "Panel_out";
			Panel_out = false;
		}

		if (Panel_in) {
			_Progress_control.Progress = "Panel_in";
			Panel_in = false;
		}
	}
}