using UnityEngine;

public class Fight_Player_Body : MonoBehaviour {

	public GameObject Main;
	bool hurt = false;
	float time = 0, hurt_time = 0;
	void Update () {

		if (time > 0)
			time -= Time.deltaTime;
		if (hurt_time > 0)
			hurt_time -= Time.deltaTime;
		if (hurt && hurt_time <= 0) {
			this.GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1);
			hurt = false;
		}
	}

	private void OnTriggerStay2D (Collider2D other) {
		if (other.tag == "Enemy_Attack" && time <= 0) {
			time += 0.5f;
			Hurt (2);
		}
	}
	void Hurt (int a) {
		this.GetComponent<SpriteRenderer> ().color = new Color (1, 0, 0, 1);
		hurt = true;
		hurt_time += 0.05f;
		Main.GetComponent<Fight_Player> ().hp -= a / Fight_Skil.effect_def;
		Main.GetComponent<Fight_Player> ().Hp.text = Main.GetComponent<Fight_Player> ().hp.ToString ();
		print ("HP=" + Main.GetComponent<Fight_Player> ().hp);
	}
}