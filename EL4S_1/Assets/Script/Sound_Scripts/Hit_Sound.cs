using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hit_Sound : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager; //サウンドマネージャー

    [SerializeField]
    private AudioClip clip1; //音源データ1

    void OnCollisionEnter(Collision other)
    {
        //Playerにぶつかったとき
        if (other.gameObject.tag == "Player")
        {
            soundManager.Play(clip1); //サウンドマネージャーを使用して効果音再生
        }
    }
}
