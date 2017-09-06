using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(0, 5 * Time.deltaTime, 0);
        if (transform.position.y >3.3)
        {
            Destroy(gameObject);
        }
        
	}
}
