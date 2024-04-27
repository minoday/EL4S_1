using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Answer_checker : MonoBehaviour
{
    [SerializeField, Header("問題数UI")]
    public Text Total_UI;

    [SerializeField, Header("正答数UI")]
    public Text Answer_UI;

    [SerializeField, Header("プレイヤー")]
    public Player_Test Player;

    [SerializeField, Header("正解か")]
    public bool Correct;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Total_UI.text = string.Format("{0}", Player.Total);
        Answer_UI.text = string.Format("{0}", Player.Score);
    }

    private void OnTriggerEnter(Collider other)
    {

        {
            //解いた問題数を数える
            Player.Total++;

            //正解かどうかの判定
            if(Correct)
            {
                Player.Score++;
                Debug.Log("正解");
            }
            else
            {
                Debug.Log("不正解");
            }

        }
    }



}
