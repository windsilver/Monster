using UnityEngine;
using UnityEngine.UI;

public class Fight_Exp : MonoBehaviour {
	public int exp, exp_add, level;
	public Text Now, Level;
	public Animation Levelup;
	void Start () {
		level = _Progress_control.load_data.level;
		Level.text = level.ToString ();
	}

	// Update is called once per frame
	void Update () {
		if (exp_add > 0) {
			exp += 1;
			exp_add -= 1;
			Now.text = exp.ToString ();
		}
		if (exp >= 100) {
			exp -= 100;
			level += 1;
			Level.text = level.ToString ();
			Now.text = exp.ToString ();
			Levelup.Play ("Fight_Levelup");
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			exp_add += 60;
		}
	}
}