using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hit_Sound : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager; //�T�E���h�}�l�[�W���[

    [SerializeField]
    private AudioClip clip1; //�����f�[�^1

    void OnCollisionEnter(Collision other)
    {
        //Player�ɂԂ������Ƃ�
        if (other.gameObject.tag == "Player")
        {
            soundManager.Play(clip1); //�T�E���h�}�l�[�W���[���g�p���Č��ʉ��Đ�
        }
    }
}
