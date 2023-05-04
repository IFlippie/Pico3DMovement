using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawningText : MonoBehaviour
{
    public GameObject spawnableText;
    public GameObject textSpawnPosition;
    public Dictionary<string, int> dict = new Dictionary<string, int>();
    string test;
    // Start is called before the first frame update
    void Start()
    {
        dict.Add("apple", 5);
        dict.Add("banana", 3);
        test = dict.ElementAt(Random.Range(0, dict.Count)).Key;
        SpawnText();       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnText() 
    {
        var go = Instantiate(spawnableText);
        Renderer r = go.GetComponent<Renderer>();
        Color newColor = r.material.color;
        newColor.a = 0;
        r.material.color = newColor;
        go.GetComponent<SimpleHelvetica>().Text = test;
        go.GetComponent<SimpleHelvetica>().GenerateText();
        go.transform.position = textSpawnPosition.transform.position;
        go.transform.localScale = new Vector3(1f, 1f, 1f);
        go.GetComponent<SimpleHelvetica>().AddBoxCollider();
        go.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        newColor.a = 1;
        r.material.color = newColor;
    }
}
