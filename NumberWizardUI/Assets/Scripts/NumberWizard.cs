﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

  int max;
  int min;
  int guess;

	// Use this for initialization
	void Start () {
    StartGame();	
	}

  void StartGame()
  {
    max = 1000;
    min = 1;
    guess = 500;

    Debug.Log("G'day mate, welcome to number wizard...");
    Debug.Log("Pick a number, but don't tell me what it is...");
    Debug.Log("The highest number you can pick is: " + max);
    Debug.Log("The lowest number you can pick is: " + min);
    Debug.Log("Tell me if your number is higher or lower than: " + guess);
    Debug.Log("Click Higher if your number is higher than " + guess);
    Debug.Log("Click Lower if your number is lower than " + guess);
    Debug.Log("Click Success if " + guess + " is correct");

    max = max + 1;

  }

  // Update is called once per frame
  void Update ()
  {
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      min = guess;
      NextGuess();
    }
    else if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      max = guess;
      NextGuess();
    }
    else if (Input.GetKeyDown(KeyCode.Return))
    {
      Debug.Log("I am psychic!!!");
      StartGame();
    }
	}

  private void NextGuess()
  {
    guess = (max + min) / 2;
    Debug.Log("Is it higher or lower than..." + guess + "?");
  }
}
