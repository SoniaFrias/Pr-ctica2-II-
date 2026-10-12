using UnityEngine;

public class CollectableTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log($"Recolectable ha sido recolectado por {collision.gameObject.name}");
    }
}
