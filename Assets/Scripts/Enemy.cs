using UnityEngine;

public class Enemy : MonoBehaviour {
		
	private void OnTriggerEnter2D(Collider2D col) {

		var playerSize = col.gameObject.AddComponent<SizePropertie>();

		playerSize.SetSize(20f);
		playerSize.ApplyPropertie();
	}
}
