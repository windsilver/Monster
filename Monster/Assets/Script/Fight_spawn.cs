using UnityEngine;

public class Fight_spawn : MonoBehaviour {
	public GameObject spawn, BugTest;
	float time = 0;
	public static int spawn_int, Enemy_int = 99;
	bool win = false;
	void Start () {
		spawn_int = 5;
		Instantiate (spawn, this.transform.position, new Quaternion (0, 0, 0, 0));
		Enemy_int = spawn_int;
		spawn_int -= 1;
		time += 10;
	}

	void Update () {
		if (time > 0)
			time -= Time.deltaTime;
		if (time <= 0 && spawn_int > 0) {
			Instantiate (spawn, this.transform.position, new Quaternion (0, 0, 0, 0));
			time += 5;
			spawn_int -= 1;
		}

		if (Enemy_int <= 0 && !win) {
			win = true;
			_Progress_control.Progress = "Player_Win";
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			Enemy_int += 1;
			Instantiate (BugTest, this.transform);
		}
		if (Input.GetKeyDown (KeyCode.I)) {
			time = 0;
		}
	}
}