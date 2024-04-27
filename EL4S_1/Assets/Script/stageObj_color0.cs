using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stageObj_color0 : MonoBehaviour
{


    // Start is called before the first frame update
    void Start() {
        this.GetComponent<Image>().color -= new Color(0, 0, 0, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
