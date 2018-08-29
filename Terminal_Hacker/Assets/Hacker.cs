﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start() {
		ShowMainMenu();
	}

	void ShowMainMenu() {
		Terminal.ClearScreen();
		Terminal.WriteLine("Hack locations: ");
		Terminal.WriteLine("1.  Local");
		Terminal.WriteLine("1.  Startup");
		Terminal.WriteLine("1.  Google");
		Terminal.WriteLine("Enter selection:");
	}

	void OnUserInput(string input){
		if (input == "menu" || input == "Menu") {
			ShowMainMenu();
		} else if (input == "007"){
			Terminal.WriteLine("Select a level Mr. Bond.");
		} else {
			Terminal.WriteLine("Invalid choice.");
		}
	}
	
	// Update is called once per frame
	void Update() {
		
	}
}
