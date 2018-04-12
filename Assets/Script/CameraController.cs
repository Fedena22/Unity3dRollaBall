using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public GameObject wand;
    private Vector3 point;
   
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        
        offset = transform.position - player.transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //transform.Rotate(Vector3.up , +90);
            //transform.LookAt(point);
            //point = player.transform.position;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        wand.GetComponent<MeshRenderer>().enabled = false;
       
        Debug.Log("Wand");

    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Immer Noch Wand");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Raus Wand");
        wand.GetComponent<MeshRenderer>().enabled = true;

    }
}
