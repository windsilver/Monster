using UnityEngine;

public class Fight_Trigger_Player : MonoBehaviour {
	public Fight_Player Player;
	void Update () {

	}
	void OnTriggerStay2D (Collider2D other) {
		if (other.gameObject.tag == "Enemy") {
			Player.action = 2;
		} else { Player.action = 0; }
	}
	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Enemy") {
			Player.action = 0;
		}
	}
}