using UnityEngine;
using System.Collections.Generic;

public class ChangeColorCollision : MonoBehaviour
{
    private Dictionary<Renderer, Color> originalColors = new Dictionary<Renderer, Color>();

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        Renderer rd = collider.gameObject.GetComponent<Renderer>();
        if (!originalColors.ContainsKey(rd))
        {
            originalColors.Add(rd, rd.material.color);
        }
        rd.material.color = Random.ColorHSV(); 
    }

    void OnTriggerExit(Collider collider)
    {
        Renderer rd = collider.gameObject.GetComponent<Renderer>();
        originalColors.TryGetValue(rd, out Color color);   
        rd.material.color = color;
        originalColors.Remove(rd);
    }
}