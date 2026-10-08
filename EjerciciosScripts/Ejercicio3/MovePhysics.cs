using UnityEngine;

public class MovePhysis : MonoBehaviour
{
    private Rigidbody rb;
    public float damage; // AÑADIDO
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 2;
        damage = 0;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 delta = direction * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + delta);
    }
}
