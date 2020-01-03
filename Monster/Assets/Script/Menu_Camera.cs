using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Camera : MonoBehaviour {
	public static int Camera_move = 0;

	void Start () {

	}

	void Update () {
		if (Camera_move != 0) {
			if (Camera_move > 0) {
				transform.localPosition += new Vector3 (0.2f, 0, 0);
				Camera_move -= 2;
			}
			if (Camera_move < 0) {
				transform.localPosition -= new Vector3 (0.2f, 0, 0);
				Camera_move += 2;
			}
		}
	}
}