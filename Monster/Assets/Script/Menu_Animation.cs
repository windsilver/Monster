using UnityEngine;

public class Menu_Animation : MonoBehaviour {
	public bool Animation_end = false;
	public int Animation_int = 0;
	void Start () {

	}

	void Update () {
		if (Animation_end) {
			if (this.name == "Grass") {
				_Progress_control.Progress = "Grass_end";
			}
			if (this.name == "Card") {
				switch (Animation_int) {
					case 1:
						_Progress_control.Progress = "Card_down";
						break;
					case 2:
						_Progress_control.Progress = "Card_up";
						break;
				}
			}
			if (this.name == "Lose") {
				_Progress_control.Progress = "Fight_Lose";
			}
			Animation_int = 0;
			Animation_end = false;
		}
	}
}