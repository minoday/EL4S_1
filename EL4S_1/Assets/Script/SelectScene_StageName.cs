using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectScene_StageName : MonoBehaviour
{
    [Header("プレイヤー"), SerializeField] private GameObject player;
    [Header("表示文言"),SerializeField]private string[] Name;
    [Header("正答数"), SerializeField] private Text AnswerText;
    [Header("正答数"), SerializeField] private ClearData m_clearData;

    private string moving = "移動中";
    private SelectSceneScript SSS;
    private Text m_text;


    // Start is called before the first frame update
    void Start() {
        SSS=player.GetComponent<SelectSceneScript>();
        m_text=GetComponent<Text>();

    }

    // Update is called once per frame
    void Update() {
        if (SSS.m_state == SelectSceneScript.STATE.MOVE) {
            m_text.text = moving;
        }
        else {
            m_text.text = Name[SSS.m_nowStage];
            string AnswerCnt;
            AnswerCnt = "正答数:" + m_clearData.stageData[SSS.m_nowStage].n_correct;

            AnswerText.text = AnswerCnt;
        }


    }
}
