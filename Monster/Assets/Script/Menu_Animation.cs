using UnityEngine;

public class Menu_Animation : MonoBehaviour {
	public bool Animation_end = false;

	void Start () {

	}

	void Update () {
		if (Animation_end) {
			if (this.name == "Grass") {
				_Progress_control.Progress = "Grass_end";
			}
			Animation_end = false;
		}
	}
}