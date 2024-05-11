using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hit_Sound : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager; //サウンドマネージャー

    [SerializeField]
    private Answer_checker ans;

    [SerializeField]
    private AudioClip clip1; //正解音源データ1
    [SerializeField]
    private AudioClip clip2; //不正解音源データ1

    

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
