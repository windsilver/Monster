using UnityEngine;
using UnityEngine.UI;
public class Fight_Player : MonoBehaviour {
	public int hp, hp_max, sp = 0;
	public int action;
	public Text Hp, Sp;
	public Animator Player_ani;
	float time = 0, sp_time = 5;
	void Start () {
		action = 1;
		hp_max = _Progress_control.load_data.HP;
		hp = hp_max;
	}

	void Update () {
		if (time > 0)
			time -= Time.deltaTime;
		if (sp_time > 0) {
			sp_time -= Time.deltaTime;
		} else {
			sp += 1;
			sp_time += 5;
			Sp.text = sp.ToString ();
		}
		if (time <= 0 && hp > 0) { //行動判斷
			switch (action) {
				case 0:
					action = 1;
					break;
				case 1:
					Player_ani.Play ("Player_Move");
					break;
				case 2:
					Player_ani.Play ("Player_Attack");
					time = 1;
					break;
			}
			time += 1;
		}
		if (action == 1 && hp > 0)
			transform.localPosition += new Vector3 (0.01f, 0, 0);
	}
}