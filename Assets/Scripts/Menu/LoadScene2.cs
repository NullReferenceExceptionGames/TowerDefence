﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene2 : MonoBehaviour {
	
	public void press(){
		SceneManager.LoadScene ("LightGrass", LoadSceneMode.Single);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
