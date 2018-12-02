using UnityEngine;

public class VelocityComponent : MonoBehaviour {

    public float Velocity { get; set; }

    private void Start() {
        Velocity = 20f;
    }
}