using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionCollision : MonoBehaviour
{
    public string CollisionID;
    private GameObject spawner;
    private void Start()
    {
        spawner = GameObject.FindWithTag("Spawner");
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Text"))
        {
            var helveticaText = collision.gameObject.GetComponent<SimpleHelvetica>();
            if (helveticaText != null)
            {
                string emotionId = helveticaText.emotionId;
                if (emotionId == CollisionID)
                {
                    Debug.Log("Variables match!");
                    Destroy(helveticaText.gameObject);
                    spawner.GetComponent<SpawningText>().SpawnText();                    
                }
                else
                {
                    Debug.Log("Variables don't match.");
                    Destroy(helveticaText.gameObject);
                    spawner.GetComponent<SpawningText>().SpawnText();
                }
            }
        }
    }
}
