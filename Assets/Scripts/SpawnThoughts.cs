using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnThoughts : MonoBehaviour
{
    public float circleRadius;
    public int AmountOfPoints;
    public GameObject FloatingText;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        float vStep = (2f * Mathf.PI) / AmountOfPoints;
        for (int o = 0; o < AmountOfPoints; o++)
        {
            Vector3 p;
            float r = circleRadius * Mathf.Cos(o * vStep);
            //Y does nothing in our example
            p.x = transform.position.x + (r * Mathf.Cos(0f));
            //p.x = transform.position.x + (r * Mathf.Sin(0f));
            //p.y = transform.position.y + (r * Mathf.Cos(0f));
            p.z = transform.position.z + (circleRadius * Mathf.Sin(o * vStep));
            p.y = transform.position.y;
            var vPos = p;

            //var go = Instantiate(FloatingText);
            //go.transform.position = vPos;
            //go.transform.LookAt(player);
        }
        var go = Instantiate(FloatingText);
        go.transform.position = new Vector3(-2,1f,0);
        go.GetComponent<SimpleHelvetica>().AddBoxCollider();
        //go.GetComponent<SimpleHelvetica>().rend.center;
        //print(go.transform.GetComponent<Renderer>().bounds.center);
    }
}
