using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            if (this.GetComponent<Rigidbody>().position.y > 0.6 && this.GetComponent<Rigidbody>().velocity.y < 0)
            {

            }
            else
            {
                this.GetComponent<Rigidbody>().velocity = new Vector3(3, 0, 0);
                print("worked");

            }
           
        }
    }
}
