using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float forward_speed;
    public float leftandright_speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //‘OˆÚ“®ˆ—
        this.transform.Translate(0.0f, 0.0f, forward_speed);

        //¶‰EˆÚ“®ˆ—
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A)) {
            this.transform.Translate(-leftandright_speed, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(leftandright_speed, 0.0f, 0.0f);
        }
    }
}
