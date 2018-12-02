using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorPropertie : IPropertie {

	public void ApplyPropertie(GameObject propertieObject) {
		var spriteRenderer = propertieObject.GetComponent<SpriteRenderer>();
		spriteRenderer.color = Color.green;
        Debug.Log("Color changer to: " + Color.green);
	}
}
