using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectSceneScript : MonoBehaviour
{
    enum STATE {
        MOVE,
        STOP
    };

    [Header("�e�X�e�[�W�̈ʒu"),SerializeField] private GameObject[] m_StagePos;

    [Header("�ړ����x,��Ԏg���̂�0~1���ړ���"),SerializeField]private float m_Speed = 0.025f;

    private float m_NowPos = 0;    //���̈ړ�����
    private STATE m_state = STATE.STOP;
    private int m_nowStage = 0;
    private int m_nextStage = 0;

    private float m_oldHorizontal;

    private RectTransform m_transform;

    [Header("�s���X�e�[�W"), SerializeField] private string[] m_nextSceneName;

    // Start is called before the first frame update
    void Start() {
        m_transform = GetComponent<RectTransform>();
        m_transform.position = m_StagePos[m_nowStage].GetComponent<RectTransform>().position;

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
                LoadScene();
            }
        }


        if(m_state == STATE.MOVE) {
            m_NowPos += m_Speed;
            Vector2.Lerp(m_transform.position, m_StagePos[m_nextStage].GetComponent<RectTransform>().position, m_NowPos);
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
