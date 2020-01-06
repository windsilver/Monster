using UnityEngine;
using UnityEngine.UI;

public class Fight_Exp : MonoBehaviour {
	public int exp, exp_add, level, points;
	public Text Now, Level, Points;
	public Animation Levelup;
	public GameObject GetSkil, Skil, Home;
	public Sprite Skil5, Skil10, Skil15, Skil20, Skil25;
	public bool win = false;
	void Start () {
		level = _Progress_control.load_data.level;
		Level.text = level.ToString ();
		points = 0;
		Points.text = "+" + points;
		exp = _Progress_control.load_data.exp;
		Now.text = exp.ToString ();
	}

	// Update is called once per frame
	void Update () {
		if (win) {
			if (exp_add > 0) {
				exp += 1;
				exp_add -= 1;
				Now.text = exp.ToString ();
			}
			if (exp >= 100 && level < 30) {
				exp -= 100;
				level += 1;
				points += 2;
				Level.text = level.ToString ();
				Now.text = exp.ToString ();
				Points.text = "+" + points;
				Levelup.Play ("Fight_Levelup");
				if (level == 5 || level == 10 || level == 15 || level == 20 || level == 25) {
					GetSkil.SetActive (true);
					switch (level) {
						case 5:
							Skil.GetComponent<Image> ().sprite = Skil5;
							_Progress_control.load_data.skil2[0] = true;
							break;
						case 10:
							Skil.GetComponent<Image> ().sprite = Skil10;
							_Progress_control.load_data.skil3[0] = true;
							break;
						case 15:
							Skil.GetComponent<Image> ().sprite = Skil15;
							_Progress_control.load_data.skil4[0] = true;
							break;
						case 20:
							Skil.GetComponent<Image> ().sprite = Skil20;
							_Progress_control.load_data.skil5[0] = true;
							break;
						case 25:
							Skil.GetComponent<Image> ().sprite = Skil25;
							_Progress_control.load_data.skil6[0] = true;
							break;
					}

				}
			}
			if (Input.GetKeyDown (KeyCode.P)) {
				exp_add += 80;
			}
			if (exp <= 0) {
				Home.gameObject.SetActive (true);
			}
		}
	}
}