using UnityEngine;

public class Fight_Trigger_Enemy : MonoBehaviour {

	public Fight_Enemy Enemy;
	void Update () {

	}
	void OnTriggerStay2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			Enemy.Enemy_action = 2;
		} else if (other.gameObject.tag != "Enemy") {
			Enemy.Enemy_action = 0;
		}
	}
	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			Enemy.Enemy_action = 0;
		}
	}
}