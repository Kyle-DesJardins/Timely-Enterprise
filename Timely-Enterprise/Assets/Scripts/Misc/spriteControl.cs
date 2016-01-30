// ***********************************************************************
// File: "control.cs"
//
// Created By: Kyle Des Jardins
//
// Created On: 1/22/2015 3:04 PM
//
// Copyright (c) 2015 All Rights Reserved, Sjögren's Game.
//
// Description:
// This generates the correct sprite for the current world that the level is on.
//
// ***********************************************************************
// REVISION HISTORY
//
// Date: 1/22/2015 3:04 PM
// By: Kyle Des Jardins
// Description: Created this script.
//
// Date: 1/28/2015 3:00 PM
// By: Kyle Des Jardins
// Added a statement to dynamically change the background as well.
//
// ***********************************************************************

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spriteControl : MonoBehaviour {

	#region Variables
	
	[SerializeField]
	private string spriteFolder;

	private Sprite levelSprite;
	private Image background;
	
	#endregion

	#region Unity Event Functions
	void Start () {
		levelSprite = Resources.Load<Sprite>(spriteFolder + "/" + Application.loadedLevelName.Substring(6,1));
		if ((gameObject.GetComponent<SpriteRenderer>())) {
			gameObject.GetComponent<SpriteRenderer>().sprite = levelSprite;
		}
		else if ((gameObject.GetComponent<Image>())) {
			gameObject.GetComponent<Image>().sprite = levelSprite;
		}
	}
	#endregion
}
