using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fight_Skil : MonoBehaviour {
	public GameObject Player;
	public Sprite[] Skil_Sprite;
	public GameObject[] Skil_Obj, Effect;
	float[] time = new float[5];
	int[] skil_sp = new int[3];
	int[] skil_num = { 0, 0, 0 };
	public Text Sp;
	public static int effect_atk, effect_def;
	void Start () {
		if (_Progress_control.load_data.skil1[1])
			Start_Skil (1);
		if (_Progress_control.load_data.skil2[1])
			Start_Skil (2);
		if (_Progress_control.load_data.skil3[1])
			Start_Skil (3);
		if (_Progress_control.load_data.skil4[1])
			Start_Skil (4);
		if (_Progress_control.load_data.skil5[1])
			Start_Skil (5);
		if (_Progress_control.load_data.skil6[1])
			Start_Skil (6);

		for (int i = 0; i < _Progress_control.load_data.skil_int; i++) {
			Skil_Obj[i].GetComponent<Image> ().sprite = Skil_Sprite[skil_num[i] - 1];
			skil_sp[i] = skil_num[i];
			Skil_Obj[i].SetActive (true);
		}
		effect_atk = 1;
		effect_def = 1;
	}

	void Update () {
		if (time[0] > 0)
			time[0] -= Time.deltaTime;
		if (time[1] > 0)
			time[1] -= Time.deltaTime;
		if (time[2] > 0)
			time[2] -= Time.deltaTime;

		if (time[3] > 0)
			time[3] -= Time.deltaTime;
		else
			effect_atk = 1;

		if (time[4] > 0)
			time[4] -= Time.deltaTime;
		else
			effect_def = 1;

		if (Player.GetComponent<Fight_Player> ().sp >= skil_sp[0] && time[0] <= 0) {
			Skil_Obj[0].GetComponent<Button> ().interactable = true;
		} else {
			Skil_Obj[0].GetComponent<Button> ().interactable = false;
		}
		if (Player.GetComponent<Fight_Player> ().sp >= skil_sp[1] && time[1] <= 0) {
			Skil_Obj[1].GetComponent<Button> ().interactable = true;
		} else {
			Skil_Obj[1].GetComponent<Button> ().interactable = false;
		}
		if (Player.GetComponent<Fight_Player> ().sp >= skil_sp[2] && time[2] <= 0) {
			Skil_Obj[2].GetComponent<Button> ().interactable = true;
		} else {
			Skil_Obj[2].GetComponent<Button> ().interactable = false;
		}
	}

	public void Skil (int a) {

		Skil_Obj[a].GetComponent<Button> ().interactable = false;
		if (skil_num[a] == 1 || skil_num[a] == 2)
			time[a] += 15;
		else if (skil_num[a] == 3 || skil_num[a] == 4)
			time[a] += 20;
		else if (skil_num[a] == 5)
			time[a] += 40;
		else
			time[a] += 60;

		if (skil_num[a] == 1) {
			effect_atk = 2;
			time[3] = 5;
		}
		if (skil_num[a] == 2) {
			effect_def = 2;
			time[4] = 10;
		}
		Instantiate (Effect[a], Player.transform);
		Player.GetComponent<Fight_Player> ().sp -= skil_sp[a];

		Sp.text = Player.GetComponent<Fight_Player> ().sp.ToString ();
	}

	void Start_Skil (int a) {
		for (int i = 0; i < skil_num.Length; i++) {
			if (skil_num[i] == 0) {
				skil_num[i] = a;
				break;
			}
		}
	}
}