using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Background : MonoBehaviour {

	void Start () {

	}

	void Update () {
		if (this.transform.localPosition.x <= -19)
			transform.localPosition = new Vector3 (19, 0, 0);
		transform.localPosition -= new Vector3 (0.1f, 0, 0);
	}
}