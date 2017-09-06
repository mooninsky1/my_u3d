using UnityEngine;
using System.Collections;

public class pig : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(0, -2 * Time.deltaTime, 0);
        if (transform.position.y < 0)
        {
            System.Random ran = new System.Random();
//             float cur_x = transform.position.x;
//             int min = (-4 - (int)cur_x);
//             int max = (4 - (int)cur_x);
//            transform.Translate(ran.Next(min, max), 3, 0);
            transform.position = new Vector3( (float)ran.Next(-4, 4), (float)3.2, (float)0.0);
        }
        
	}

    // 碰撞
    void OnTriggerEnter(Collider other)
    {
        //如果碰撞的对象是炮弹
        if (other.tag == "shoot" )
        {
            System.Random ran = new System.Random();
            transform.position = new Vector3((float)ran.Next(-4, 4), (float)3.2, (float)0.0);
            Destroy(other.gameObject);
        }
        else if (other.tag == "player")
        {
            System.Random ran = new System.Random();
            transform.position = new Vector3((float)ran.Next(-4, 4), (float)3.2, (float)0.0);
        }
    }
}
