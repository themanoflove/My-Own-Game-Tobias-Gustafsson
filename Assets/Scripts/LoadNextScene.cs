using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour {
    public string chosenscene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //Den här gör så att när något rör objectet där detta scriptet är på laddas en ny scene som jag har bestämt i unity
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(chosenscene);
    }
}
