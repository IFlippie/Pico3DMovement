using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmotionCollision : MonoBehaviour
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
                    correctIncorrect.text = "This is correct";
                }
                else
                {
                    Debug.Log("Variables don't match.");
                    Destroy(helveticaText.gameObject);
                    spawner.GetComponent<SpawningText>().SpawnText();
                    correctIncorrect.text = "This is wrong";
                }
            }
        }
    }
}
