using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ballGo;
    public Transform playerPos;
    // Start is called before the first frame update
    void Start()
    {
        var go = Instantiate(ballGo);
        go.transform.position = playerPos.position + new Vector3(0, 1, 1f);
        go.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 5f), ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
