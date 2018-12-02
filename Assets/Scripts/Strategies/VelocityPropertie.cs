using System;
using UnityEngine;

public class VelocityPropertie : IPropertie {

    public void ApplyPropertie(GameObject propertieObject) {
        var targetVelocityComponent = propertieObject.GetComponent<VelocityComponent>();
        targetVelocityComponent.Velocity = 40f;
        Debug.Log("Velocity changed to: " + 40f);
    }
}
