using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	int Hp = 5;
	float time = 0;
	void Update () {

		if (time > 0)
			time -= Time.deltaTime;
	}

	private void OnTriggerStay2D (Collider2D other) {
		if (other.tag == "Player_Attack" && time <= 0) {
			time += 0.5f;
			Hurt ();
		}
	}
	void Hurt () {
		Hp -= 1;
		print ("HP=" + Hp);
		if (Hp == 0) {
			Destroy (this.gameObject);
		}
	}
}