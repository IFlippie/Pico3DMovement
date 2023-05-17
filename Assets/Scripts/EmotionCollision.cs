using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionCollision : MonoBehaviour
{
    public string objectVariable;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Text"))
        {
            var textObject = collision.gameObject.GetComponent<SimpleHelvetica>();
            if (textObject != null)
            {
                string textVariable = textObject.emotionId;
                if (textVariable == objectVariable)
                {
                    Debug.Log("Variables match!");
                }
                else
                {
                    Debug.Log("Variables don't match.");
                }
            }
        }
    }
}
