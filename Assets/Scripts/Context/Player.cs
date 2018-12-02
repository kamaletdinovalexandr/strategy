using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private VelocityComponent _velocityComponent;

	private IPropertie _propertie;

    private void Start() {
        _velocityComponent = GetComponent<VelocityComponent>();
    }

    private void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector3(moveHorizontal, moveVertical);
		transform.Translate(movement * _velocityComponent.Velocity * Time.deltaTime);
	}

	public void ApplyPropertie(IPropertie propertie) {
		_propertie = propertie;
		_propertie.ApplyPropertie(this.gameObject);
	}
}
