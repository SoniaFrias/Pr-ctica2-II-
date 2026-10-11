using UnityEngine;

public class AddForce : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.X))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward, ForceMode.Impulse);
        }
        
    }
}
