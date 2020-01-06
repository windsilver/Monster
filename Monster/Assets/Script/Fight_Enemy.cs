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

	void Start () {
		Enemy_action = 0;
		hp = hp_max;
		Enemy_text = GameObject.Find ("Enemy_Text").GetComponent<Text> ();
	}

	void Update () {
		if (time > 0)
			time -= Time.deltaTime;
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
					time = 2;
					break;
			}
			time += 1;
		}
		if (Enemy_action == 1 && hp > 0)
			transform.localPosition -= new Vector3 (0.01f, 0, 0);
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