using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinDestroy : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        GameObject levelset = GameObject.Find("Levelsettings");
        levelset.GetComponent<levelSettings>().colCoins++;
        
        //Destroy(gameObject);
        gameObject.SetActive(false);
       
        
        Debug.Log ("Treffer");
    }

}
