using UnityEngine;
using System.Collections;

public class A
{
//     public A()
//     {
//         x = 0;
//     }
    public int x;//{get;set;}
}
public class PlayerCtl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        A a=new A();
        a.x = 1;
	
	}
    public shoot a;
	// Update is called once per frame
	void Update () {
        if (transform.position.x<4.1 ||
            transform.position.x>-4.1)
        {
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        }
         transform.Translate(0, Input.GetAxis("Vertical") * Time.deltaTime, 0);
        //循环移动
        if (transform.position.x>4.1)
        {
            transform.Translate( (float)-8.0 , 0 , 0 );
           transform.position.Set((float)-4.0, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -4.1)
        {
            transform.Translate( (float)8.0 ,  0 ,  0 );
            //transform.position.Set((float)4.0, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(a, transform.position, transform.rotation);
        }
        
        
	}
}
