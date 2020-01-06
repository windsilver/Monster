using UnityEngine;
public class Fight_Enemy_Body : MonoBehaviour {
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
		if (other.tag == "Player_Attack" && time <= 0) {
			time += 0.5f;
			Hurt ();
		}
	}
	void Hurt () {
		this.GetComponent<SpriteRenderer> ().color = new Color (1, 0, 0, 1);
		hurt = true;
		hurt_time += 0.05f;
		Main.GetComponent<Fight_Enemy> ().hp -= _Progress_control.load_data.ATK * Fight_Skil.effect_atk;
		print ("HP=" + Main.GetComponent<Fight_Enemy> ().hp);
	}
}