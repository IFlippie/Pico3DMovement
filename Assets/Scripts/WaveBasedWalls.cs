using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveBasedWalls : MonoBehaviour
{
    public int currentWave = 0;
    public GameObject waveObject;
    public Transform waveSpawnPoint;
    public int remainingBricks = 0;
    public Text currentScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = GameObject.FindGameObjectWithTag("WaveScore").GetComponent<Text>();
        currentScore.text = currentWave.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingBricks <= 0) 
        {
            SpawnNewWave();
            currentScore.text = currentWave.ToString();
        }
    }

    void SpawnNewWave() 
    {
        var newWave = Instantiate(waveObject);
        newWave.transform.position = waveSpawnPoint.position;
        remainingBricks = 4;
        currentWave += 1;
    }
}
