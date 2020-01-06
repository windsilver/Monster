using UnityEngine;

public class Fight_Effect : MonoBehaviour {
	public bool end = false;

	void Update () {
		if (end)
			Destroy (this.gameObject);
	}
}