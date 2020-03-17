using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {
    public int window;
    private void Awake()
    {
        window = 1;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        GUI.BeginGroup(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 300, 300));
//        GUI.Button(new Rect(10, 30, 180, 100), "Играть");
        if (GUI.Button(new Rect(10, 30, 180, 100), "Играть"))
        {
            SceneManager.LoadScene("SampleScene",LoadSceneMode.Single); 
            
            //Application.LoadLevel("SampleScene");
        }
        GUI.EndGroup();
       
    }
}
