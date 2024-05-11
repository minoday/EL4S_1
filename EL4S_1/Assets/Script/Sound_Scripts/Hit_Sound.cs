using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hit_Sound : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager; //�T�E���h�}�l�[�W���[

    [SerializeField]
    private Answer_checker ans;

    [SerializeField]
    private AudioClip clip1; //���������f�[�^1
    [SerializeField]
    private AudioClip clip2; //�s���������f�[�^1

    

    void OnTriggerEnter(Collider other)
    {
        //Player�ɂԂ������Ƃ�
        if (other.gameObject.tag == "Player")
        {
            if(ans.Correct == true)soundManager.Play(clip1); //�T�E���h�}�l�[�W���[���g�p���Č��ʉ��Đ�
            if(ans.Correct == false)soundManager.Play(clip2); //�T�E���h�}�l�[�W���[���g�p���Č��ʉ��Đ�
        }
    }
}
