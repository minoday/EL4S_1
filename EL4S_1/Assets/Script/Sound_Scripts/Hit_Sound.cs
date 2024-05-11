using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hit_Sound : MonoBehaviour
{
    [SerializeField, Header("サウンドマネージャー")]
    private SoundManager soundManager; //サウンドマネージャー

    [SerializeField, Header("Correctチェック")]
    private Answer_checker ans;

    [SerializeField, Header("正解音源データ")]
    private AudioClip clip1; //正解音源データ
    [SerializeField, Header("不正解音源データ")]
    private AudioClip clip2; //不正解音源データ

    

    void OnTriggerEnter(Collider other)
    {
        //Playerにぶつかったとき
        if (other.gameObject.tag == "Player")
        {
            if(ans.Correct == true)soundManager.Play(clip1); //サウンドマネージャーを使用して効果音再生
            if(ans.Correct == false)soundManager.Play(clip2); //サウンドマネージャーを使用して効果音再生
        }
    }
}
