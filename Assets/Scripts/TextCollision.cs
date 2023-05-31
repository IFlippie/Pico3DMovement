using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCollision : MonoBehaviour
{
    public string CollisionID;
    private GameObject spawner;
    private void Start()
    {
        spawner = GameObject.FindWithTag("Spawner");
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("NinjaStick"))
        {
                if (CollisionID == "Pos")
                {
                    Debug.Log("Variable is positive!");
                    spawner.GetComponent<SpawnThoughts>().ClearSpawns();
                    spawner.GetComponent<SpawnThoughts>().ThoughtSpawns();
                }
                else
                {
                    Debug.Log("Variable is negative!");
                    spawner.GetComponent<SpawnThoughts>().ClearSpawns();
                    spawner.GetComponent<SpawnThoughts>().ThoughtSpawns();
                }
        }
    }
}
