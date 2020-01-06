using UnityEngine;
using UnityEngine.UI;

public class Fight_Enemy : MonoBehaviour {
	public bool Die;

	public int hp, hp_max = 10;
	public int Enemy_action;

	public Animator Enemy_ani;
	public GameObject Hp_Bar;
	public Text Enemy_text;
	float time = 0;
	public float atk_time = 2, move_x = 0.03f;

	void Start () {
		if (this.tag == "Bug_Test") {
			atk_time = -0.8f;
			move_x = 0.2f;
		}
		Enemy_action = 0;
		hp = hp_max;
		Enemy_text = GameObject.Find ("Enemy_Text").GetComponent<Text> ();
	}

	void Update () {
		if (time > 0)
			time -= Time.deltaTime;
		if (hp <= 0)
			Hp_Bar.transform.localScale = new Vector3 (0, 1, 1);
		else
			Hp_Bar.transform.localScale = new Vector3 ((float) hp / hp_max, 1, 1);
		if (time <= 0 && hp > 0) { //行動判斷
			switch (Enemy_action) {
				case 0:
					Enemy_action = 1;
					break;
				case 1:
					Enemy_ani.Play ("Enemy_Move");
					break;
				case 2:
					Enemy_ani.Play ("Enemy_Attack");
					time = atk_time;
					break;
			}
			time += 1;
		}
		if (Enemy_action == 1 && hp > 0)
			transform.localPosition -= new Vector3 (move_x, 0, 0);
		if (hp <= 0) {
			Enemy_ani.Play ("Enemy_Die");
		}
		if (Die) {
			Fight_spawn.Enemy_int -= 1;
			Enemy_text.text = "=  " + Fight_spawn.Enemy_int;
			Destroy (this.gameObject);
		}
	}
}