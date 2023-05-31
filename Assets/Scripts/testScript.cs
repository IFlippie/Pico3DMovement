using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public Transform EmptyParent;
    public Transform player;
    bool doneOnce = false;
    void OnBecameVisible()
    {
        if (doneOnce != true) 
        {
            player = GameObject.Find("CameraOffset").transform;
            transform.localScale = new Vector3(1f, 1f, 1f);
            gameObject.GetComponent<SimpleHelvetica>().AddBoxCollider();
            transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

            //Only do this if you 180 on the y axis
            //transform.GetComponent<BoxCollider>().center = new Vector3(-transform.GetComponent<BoxCollider>().center.x, transform.GetComponent<BoxCollider>().center.y, -transform.GetComponent<BoxCollider>().center.z);

            transform.SetParent(EmptyParent.transform);
            EmptyParent.transform.LookAt(player);
            EmptyParent.transform.rotation = new Quaternion(0f, EmptyParent.transform.rotation.y, 0f, EmptyParent.transform.rotation.w);
            
            //print(transform.InverseTransformPoint(transform.position));
            transform.localPosition = new Vector3((transform.GetComponent<BoxCollider>().center.x*0.01f), (transform.GetComponent<BoxCollider>().center.y * 0.01f), (transform.GetComponent<BoxCollider>().center.z * 0.01f));

            transform.Rotate(new Vector3(0f, 180f, 0f));
            transform.GetComponent<BoxCollider>().isTrigger = true;
            StartCoroutine(StartColl());
            doneOnce = true;
        }
    }

    public IEnumerator StartColl() 
    {
        transform.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(2f);
        transform.GetComponent<BoxCollider>().enabled = true;
    }
}
