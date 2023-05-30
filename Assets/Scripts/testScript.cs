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

            //var goParent = Instantiate(EmptyParent);
            //goParent.transform.position = transform.GetComponent<SimpleHelvetica>().rend.center;
            transform.SetParent(EmptyParent.transform);
            EmptyParent.transform.LookAt(player);
            EmptyParent.transform.rotation = new Quaternion(0f, EmptyParent.transform.rotation.y, 0f, EmptyParent.transform.rotation.w);
            transform.position = EmptyParent.transform.position + transform.TransformPoint(transform.GetComponent<BoxCollider>().center);
            //print(transform.GetComponent<BoxCollider>().center);
            print(transform.TransformPoint(transform.GetComponent<BoxCollider>().center));
            transform.Rotate(new Vector3(0f, 180f, 0f));
            doneOnce = true;
            //add parent, get center of it, lookat player and fix rotation because of height difference
        }
    }
}
