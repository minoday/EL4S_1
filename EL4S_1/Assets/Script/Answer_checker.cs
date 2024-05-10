using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Answer_checker : MonoBehaviour
{
    //[SerializeField, Header("��萔UI")]
    //public Text Total_UI;

    [SerializeField, Header("������UI")]
    public Text Answer_UI;

    [SerializeField, Header("�v���C���[")]
    public Player_Test Player;

    [SerializeField, Header("������")]
    public bool Correct;

    [SerializeField, Header("�񓚍ςł��邩")]
    private AnsweredCheck answeredCheck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Total_UI.text = string.Format("{0}", Player.Total);
        Answer_UI.text = string.Format("{0}", Player.Score);
    }

    private void OnTriggerEnter(Collider other)
    {

        if(!answeredCheck.is_answered)
        {
            //��������萔�𐔂���
            Player.Total++;

            //�������ǂ����̔���
            if (Correct)
            {
                Player.Score++;
                Debug.Log("����");
            }
            else
            {
                Debug.Log("�s����");
            }

            answeredCheck.is_answered = true;
        }
        else
        {
            Debug.Log("�񓚍�");
        }
    }
}
