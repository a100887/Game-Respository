using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour {

    static MusicPlayerScript instance = null;
    //static bool availablePlayer = false;

	// Use this for initialization
	void Start () {

        //if (availablePlayer == false)
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
            //availablePlayer = true;
        }

        else
        {
            Destroy(gameObject);
            print("Duplicate Music Player is self destructing!");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
