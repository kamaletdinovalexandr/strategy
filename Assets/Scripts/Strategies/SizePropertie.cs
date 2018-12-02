using System;
using UnityEngine;

public class SizePropertie : IPropertie {

    public void ApplyPropertie(GameObject propertieObject) {
        var targetTransform = propertieObject.GetComponent<Transform>();
        targetTransform.localScale = new Vector2(2, 2);
        Debug.Log("Size changed to: " + targetTransform.localScale);
    }
}
