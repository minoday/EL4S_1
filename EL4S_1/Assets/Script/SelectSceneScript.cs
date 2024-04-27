using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectSceneScript : MonoBehaviour
{
    enum STATE {
        MOVE,
        STOP
    };

    [Header("各ステージの位置"),SerializeField] private GameObject[] m_StagePos;
    

    private float m_NowPos = 0;    //今の移動割合
    private STATE m_state = STATE.STOP;


    private float m_oldHorizontal;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (m_state == STATE.STOP) {
            


        }



        m_oldHorizontal = Input.GetAxis("Horizontal");
    }
}
