using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KModkit;

public class TestScript : MonoBehaviour
{
    static int _moduleIdCounter = 1;
    int _moduleID = 0;

    public KMBombModule Module;
	public KMSelectable Button;

	void Awake()
	{
		_moduleID = _moduleIdCounter++;
		Button.OnInteract += delegate { Module.HandlePass(); return false; };

		// I hate making dummy modules. Too much effort.
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
