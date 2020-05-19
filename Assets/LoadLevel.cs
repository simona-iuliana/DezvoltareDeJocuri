using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

    public string startlevel;

    public GameObject winn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Startgame()
    {
        Application.LoadLevel(startlevel);    
    }
    public void Quitlvl()
    {
        Application.Quit(); 

    }
     void OnTriggerEnter2D(Collider2D other)
    {
        winn.SetActive(true);
    }

}
