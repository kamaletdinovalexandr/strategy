using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private IPropertie _propertie;
	private PlayerSpeed _speed;

	private void Start() {
		_speed = transform.gameObject.AddComponent<PlayerSpeed>();
		_speed.Value = 20f;
	}

	void FixedUpdate () {
		if (_speed == null)
			return;

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector2 movement = new Vector3(moveHorizontal, moveVertical);
		transform.Translate(movement * _speed.Value * Time.deltaTime);
	}

	public void ApplyPropertie(IPropertie propertie) {
		_propertie = propertie;
		_propertie.ApplyPropertie();
	}

	private void OnTriggerEnter2D(Collider2D col) {
		Debug.Log(col.gameObject.name + " Hited!!!");
	}
}
