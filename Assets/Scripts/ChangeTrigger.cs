using UnityEngine;

public class BaseChangeTrigger : MonoBehaviour {
    protected IPropertie _propertie;

    protected void OnTriggerEnter2D(Collider2D col) {
        var player = col.gameObject.GetComponent<Player>();
        player.ApplyPropertie(_propertie);
    }
}
