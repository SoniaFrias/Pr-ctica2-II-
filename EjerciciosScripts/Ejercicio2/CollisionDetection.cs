using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private Renderer rd;

    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Random.ColorHSV();
        Debug.Log($"Soy {name} y choqué contra {collision.gameObject.name}");
    }

}
