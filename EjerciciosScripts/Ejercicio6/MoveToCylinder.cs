using UnityEngine;

public class MoveToCylinder: MonoBehaviour
{
    private GameObject cylinder;
    private GameObject cube;
    private Collider sphere;
    public Material newMaterial;

    void Start()
    {
        cylinder = GameObject.FindWithTag("Cylinder");
        cube = GameObject.FindWithTag("Cube");
        sphere = GetComponent<Collider>();
    }

    void Update()
    {
        Vector3 direction = (cylinder.transform.position - transform.position);
        direction.y = 0;
        direction = direction.normalized;
        transform.Translate(direction * 3 * Time.deltaTime, Space.World);


        if (cube.GetComponent<Collider>().bounds.Intersects(sphere.bounds))
        {
            cube.GetComponent<Renderer>().material = newMaterial;
        }
    }
}