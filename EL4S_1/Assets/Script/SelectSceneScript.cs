using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectSceneScript : MonoBehaviour
{
    public enum STATE {
        MOVE,
        STOP
    };

    [Header("各ステージの位置"),SerializeField] private GameObject[] m_StagePos;

    [Header("移動速度,補間使うので0~1が移動中"),SerializeField]private float m_Speed = 0.025f;

    private float m_NowPos = 0;    //今の移動割合
    [HideInInspector]public STATE m_state = STATE.STOP;
    [HideInInspector]public int m_nowStage = 0;
    private int m_nextStage = 0;

    private float m_oldHorizontal;

    private RectTransform m_transform;

    [Header("行くステージ"), SerializeField] private string[] m_nextSceneName;
    [SerializeField]private ClearData m_clearData;

    // Start is called before the first frame update
    void Start() {
        m_transform = GetComponent<RectTransform>();
        m_transform.position = m_StagePos[m_nowStage].GetComponent<RectTransform>().position;
        m_nowStage = m_clearData.selectStage;
    }

    // Update is called once per frame
    void Update() {
        if (m_state == STATE.STOP) {
            if(Input.GetAxis("Horizontal") > 0 && m_oldHorizontal <= 0) {
                m_nextStage = m_nowStage + 1;
                m_nextStage %= 5;


                m_state = STATE.MOVE;
                m_NowPos = 0;
            }
            else if(Input.GetAxis("Horizontal") < 0 && m_oldHorizontal >= 0) {
                m_nextStage = m_nowStage - 1;
                if (m_nextStage < 0) {
                    m_nextStage = 4;
                }


                m_state = STATE.MOVE;
                m_NowPos = 0;
            }
            else if (Input.GetButton("Submit")) {

                m_clearData.selectStage = this.m_nowStage;
                LoadScene();
            }
        }


        if(m_state == STATE.MOVE) {
            if (m_StagePos[m_nowStage].GetComponent<RectTransform>().position.x > m_StagePos[m_nextStage].GetComponent<RectTransform>().position.x) {
                this.transform.localScale = new Vector3(1,1,1);
            }
            else {
                this.transform.localScale = new Vector3(-1, 1, 1);
            }
            m_NowPos += m_Speed;
            m_transform.position= Vector3.Lerp(m_StagePos[m_nowStage].GetComponent<RectTransform>().position, m_StagePos[m_nextStage].GetComponent<RectTransform>().position, m_NowPos);
            if (m_NowPos >= 1) {
                m_transform.position = m_StagePos[m_nextStage].GetComponent<RectTransform>().position;
                m_nowStage = m_nextStage;
                m_state=STATE.STOP;
            }
        }

        m_oldHorizontal = Input.GetAxis("Horizontal");
    }

    public void LoadScene() {
        SceneManager.LoadScene(m_nextSceneName[m_nowStage]);
    }
}
