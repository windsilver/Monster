using UnityEngine;

public class Fight_spawn : MonoBehaviour {
	public GameObject spawn;
	float time = 0;
	public static int spawn_int = 5, Enemy_int = 99;
	bool win = false;
	void Start () {
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
			time += 10;
			spawn_int -= 1;
		}

		if (Enemy_int <= 0 && !win) {
			win = true;
			_Progress_control.Progress = "Player_Win";
		}
	}
}