using System;
using UnityEngine;

public class ColorPropertie : MonoBehaviour , IPropertie {
	
	private Color _color;

	public void SetColorPropertie(Color color) {
		_color = color;
	}

	public void ApplyPropertie() {
		var spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.color = _color;
	}
}
