﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void start(){
		SceneManager.LoadScene ("Main", LoadSceneMode.Single);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
