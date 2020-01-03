using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Progress_control : MonoBehaviour {
	public static string Progress = "";
	public GameObject Panel;

	void Start () {
		Progress = "";
		Panel.GetComponent<Animation> ().Play ("Panel_out");
	}

	void Update () {
		if (Progress != "") {
			switch (Progress) {
				case "Panel_out":
					print ("out");
					break;

			}
			Progress = "";
		}
	}
}