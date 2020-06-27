using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class damage : MonoBehaviour
{
    private int hp;
    private bool invuln;
    // Start is called before the first frame update
    void Start()
    {
        hp = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 10 == 0 &&invuln == true)
        {
            hp -= 1;
        }
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "NME")
        {
            hp -= 1;
            invuln = true;
        }
        
    }
    void OnCollisionExit2D(Collision2D c)
    {
        if (c.gameObject.tag == "NME")
        {
            invuln = false;
        }
    }
}
