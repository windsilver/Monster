using UnityEngine;

public class Menu_Icon_up : MonoBehaviour {
	void Update () {
		if (this.transform.localPosition.y < 2) {
			this.transform.localPosition += new Vector3 (0, 0.05f, 0);
			this.GetComponent<SpriteRenderer> ().color -= new Color (0, 0, 0, 0.025f);
		} else
			Destroy (this.gameObject);

	}
}