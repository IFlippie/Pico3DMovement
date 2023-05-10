using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    public GameObject block;
    public GameObject blockWall;
    public List<GameObject> blockList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        //for randomized blocks this will have to do
        //for (int h = 0; h < 10; h++)
        //{
        //    for (int j = 0; j < 10; j++)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            var tempBlock = Instantiate(block);
        //            tempBlock.transform.position = new Vector3(i * 1.1f, (j * 0.6f) + 1f, (h * 0.7f) + 8f);
        //            blockList.Add(tempBlock);
        //        }
        //    }
        //}

        for (int i = 0; i < 10; i++)
        {
            var tempBlock = Instantiate(blockWall);
            tempBlock.transform.position = new Vector3(-1,0 ,(i * 0.7f) + 8f);
            blockList.Add(tempBlock);
        }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
