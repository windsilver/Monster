using UnityEngine;
using UnityEngine.UI;

public class Fight_spawn : MonoBehaviour {
	public GameObject spawn;
	public Text Enemy_text;
	float time = 0;
	int spawn_int = 5;
	void Start () {
		Instantiate (spawn, this.transform.position, new Quaternion (0, 0, 0, 0));
		spawn_int -= 1;
		time += 10;
		Enemy_text.text = "=  " + spawn_int;
	}

	void Update () {
		if (time > 0)
			time -= Time.deltaTime;
		if (time <= 0 && spawn_int > 0) {
			Instantiate (spawn, this.transform.position, new Quaternion (0, 0, 0, 0));
			time += 10;
			spawn_int -= 1;
			Enemy_text.text = "=  " + spawn_int;
		}
	}
}