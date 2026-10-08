
using UnityEngine;

public class AddDamage : MonoBehaviour
{
    public float damage = 2;
    void OnTriggerStay(Collider collider)
    {
        MovePhysis data = collider.gameObject.GetComponent<MovePhysis>();
        data.damage += damage * Time.fixedDeltaTime;
    }
}
