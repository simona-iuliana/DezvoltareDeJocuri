using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

    public GameObject player;
    public GameObject checkpoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Initate()
    {
        Instantiate(player, checkpoint.transform.position,checkpoint.transform.rotation);
    }
}
