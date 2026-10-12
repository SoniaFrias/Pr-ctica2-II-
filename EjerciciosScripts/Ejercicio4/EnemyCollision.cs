using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"El enemi ha chocado contra {collision.gameObject.name}");
    }
}
