using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public Transform ball, barrel,mermi,nokta;
    Transform klon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ball.Rotate(0,Input.GetAxis("Horizontal"),0);
        barrel.Rotate( Input.GetAxis("Vertical"), 0,0);
        if (Input.GetKeyDown(KeyCode.Space )) {
           
                Instantiate(mermi, nokta.position, barrel.rotation);
            klon=Instantiate(mermi, nokta.position, barrel.rotation);
            klon.GetComponent<Rigidbody>().AddForce(klon.forward*1000f);
        }
    }
}
