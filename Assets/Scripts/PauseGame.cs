﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    public Transform canvas;
    public Transform Player;
	
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Escape)){
            if (canvas.gameObject.activeInHierarchy == false){
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
                Player.GetComponent<PlayerController>().enabled = false;            
            }
            else{
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
                Player.GetComponent<PlayerController>().enabled = true;       
            }
        }	
	}
}