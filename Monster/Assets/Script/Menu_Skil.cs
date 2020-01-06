using UnityEngine;
using UnityEngine.UI;

public class Menu_Skil : MonoBehaviour {
	public GameObject on, off;
	bool Skil_bool = false;
	void Start () {
		switch (this.name) {
			case "Skil1":
				if (_Progress_control.load_data.skil1[0] == false)
					off.GetComponent<Button> ().interactable = false;
				else {
					off.GetComponent<Button> ().interactable = true;
					if (_Progress_control.load_data.skil1[1] == false) {
						off.SetActive (true);
						on.SetActive (false);
						Skil_bool = false;
					} else {
						off.SetActive (false);
						on.SetActive (true);
						Skil_bool = true;
					}
				}
				break;
			case "Skil2":
				if (_Progress_control.load_data.skil2[0] == false)
					off.GetComponent<Button> ().interactable = false;
				else {
					off.GetComponent<Button> ().interactable = true;
					if (_Progress_control.load_data.skil2[1] == false) {
						off.SetActive (true);
						on.SetActive (false);
						Skil_bool = false;
					} else {
						off.SetActive (false);
						on.SetActive (true);
						Skil_bool = true;
					}
				}
				break;
			case "Skil3":
				if (_Progress_control.load_data.skil3[0] == false)
					off.GetComponent<Button> ().interactable = false;
				else {
					off.GetComponent<Button> ().interactable = true;
					if (_Progress_control.load_data.skil3[1] == false) {
						off.SetActive (true);
						on.SetActive (false);
						Skil_bool = false;
					} else {
						off.SetActive (false);
						on.SetActive (true);
						Skil_bool = true;
					}
				}
				break;
			case "Skil4":
				if (_Progress_control.load_data.skil4[0] == false)
					off.GetComponent<Button> ().interactable = false;
				else {
					off.GetComponent<Button> ().interactable = true;
					if (_Progress_control.load_data.skil4[1] == false) {
						off.SetActive (true);
						on.SetActive (false);
						Skil_bool = false;
					} else {
						off.SetActive (false);
						on.SetActive (true);
						Skil_bool = true;
					}
				}
				break;
			case "Skil5":
				if (_Progress_control.load_data.skil5[0] == false)
					off.GetComponent<Button> ().interactable = false;
				else {
					off.GetComponent<Button> ().interactable = true;
					if (_Progress_control.load_data.skil5[1] == false) {
						off.SetActive (true);
						on.SetActive (false);
						Skil_bool = false;
					} else {
						off.SetActive (false);
						on.SetActive (true);
						Skil_bool = true;
					}
				}
				break;
			case "Skil6":
				if (_Progress_control.load_data.skil6[0] == false)
					off.GetComponent<Button> ().interactable = false;
				else {
					off.GetComponent<Button> ().interactable = true;
					if (_Progress_control.load_data.skil6[1] == false) {
						off.SetActive (true);
						on.SetActive (false);
						Skil_bool = false;
					} else {
						off.SetActive (false);
						on.SetActive (true);
						Skil_bool = true;
					}
				}
				break;
		}
	}
	public void z_Skil () {
		if (!Skil_bool && _Progress_control.load_data.skil_int < 3) {
			off.SetActive (false);
			on.SetActive (true);
			_Progress_control.load_data.skil_int += 1;
			Skil_2 ();
		} else if (Skil_bool) {
			off.SetActive (true);
			on.SetActive (false);
			_Progress_control.load_data.skil_int -= 1;
			Skil_2 ();
		}
	}

	void Skil_2 () {
		Skil_bool = !Skil_bool;
		switch (this.name) {
			case "Skil1":
				_Progress_control.load_data.skil1[1] = !_Progress_control.load_data.skil1[1];
				break;
			case "Skil2":
				_Progress_control.load_data.skil2[1] = !_Progress_control.load_data.skil2[1];
				break;
			case "Skil3":
				_Progress_control.load_data.skil3[1] = !_Progress_control.load_data.skil3[1];
				break;
			case "Skil4":
				_Progress_control.load_data.skil4[1] = !_Progress_control.load_data.skil4[1];
				break;
			case "Skil5":
				_Progress_control.load_data.skil5[1] = !_Progress_control.load_data.skil5[1];
				break;
			case "Skil6":
				_Progress_control.load_data.skil6[1] = !_Progress_control.load_data.skil6[1];
				break;
		}
	}
}