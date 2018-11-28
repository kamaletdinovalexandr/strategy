using System;
using UnityEngine;

public class SizePropertie : MonoBehaviour, IPropertie {
	
	private float _size;

	public void SetSize(float newSize) {
		_size = newSize;
	}
	public void ApplyPropertie() {
		transform.localScale = new Vector2(_size, _size);
	}
}