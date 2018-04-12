using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelSettings : MonoBehaviour {

    public int maxCoins;
    public int colCoins =0;
    public GameObject ziel;
    public GameObject zielBlocker;
    public float timeForLevel;
    public Text textCoins;
    public Text textTime;


	// Use this for initialization
	void Start () {
        textCoins.text = "Coins: " + colCoins + " / " + maxCoins;
        textTime.text = "Zeit: " + timeForLevel;
        //ziel.SetActive(false);

	}
	
	// Update is called once per frame
	void Update() {
        countdown();
        coinCount();
 
    }
    private void LateUpdate()
    {
        coinComplet();
    }
    public void countdown ()
    {
        // timeForLevel--;
        timeForLevel -= Time.deltaTime;
        textTime.text = "Zeit: " + Mathf.Round(timeForLevel);
        
        if (timeForLevel < 0)
        {
            //Application.LoadLevel("startmenu");
            SceneManager.LoadScene("startmenu");
        }


    }
    public void coinCount(){
        textCoins.text = "Coins: " + colCoins + " / " + maxCoins;
    }
    public void coinComplet()
    {
        if(colCoins == maxCoins)
        {
            //Debug.Log("Level Geschaft");
            //ziel.SetActive(true);
            zielBlocker.SetActive(false);
        }
    }
} 


