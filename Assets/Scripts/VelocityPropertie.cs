using System;
using UnityEngine;

public class VelocityPropertie : MonoBehaviour, IPropertie {
	
	private float _velocity;

	public VelocityPropertie(float velocity) {
		_velocity = velocity;
	}

	public void ApplyPropertie() {
		var speed = GetComponent<PlayerSpeed>();
		speed.Value = _velocity;
	}
}
