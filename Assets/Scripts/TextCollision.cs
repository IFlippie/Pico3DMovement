using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class TextCollision : MonoBehaviour
{
    public string CollisionID;
    private GameObject spawner;
    public Text correctIncorrect;
    private void Start()
    {
        spawner = GameObject.FindWithTag("Spawner");
        correctIncorrect = GameObject.FindWithTag("WaveScore").GetComponent<Text>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("NinjaStick") && collision.gameObject.GetComponent<XRGrabInteractable>().isSelected)
        {
                if (CollisionID == "Pos")
                {
                    Debug.Log("Variable is positive!");
                    spawner.GetComponent<SpawnThoughts>().ClearSpawns();
                    spawner.GetComponent<SpawnThoughts>().ThoughtSpawns();
                    correctIncorrect.text = "This is correct";
                }
                else
                {
                    Debug.Log("Variable is negative!");
                    spawner.GetComponent<SpawnThoughts>().ClearSpawns();
                    spawner.GetComponent<SpawnThoughts>().ThoughtSpawns();
                    correctIncorrect.text = "This is wrong";
            }
        }
    }
}
