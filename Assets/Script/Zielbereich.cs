using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zielbereich : MonoBehaviour {
    public string levelName;
    public GameObject uiText;
    private void OnTriggerStay (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Ziel erreicht");
            uiText.SetActive(true);
            Invoke("levelChange", 5);
          
        }
    
    }
    public void levelChange()
    {
        SceneManager.LoadScene(levelName);
    }
}
