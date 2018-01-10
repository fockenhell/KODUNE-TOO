using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pudel : MonoBehaviour {

    public GameObject player;
    //private Collider c;
    public GameObject obj;

	// Use this for initialization
	void Start () {
       //Collider c = gameObject.GetComponent<BoxCollider>;
	}

    private void OnTriggerEnter(Collider player)
    {
        obj.SetActive(false);
      
    }

    // Update is called once per frame
    void Update () {
		
	}
}
