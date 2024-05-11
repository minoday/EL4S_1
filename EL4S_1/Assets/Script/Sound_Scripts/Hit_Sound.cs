using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hit_Sound : MonoBehaviour
{
    [SerializeField, Header("�T�E���h�}�l�[�W���[")]
    private SoundManager soundManager; //�T�E���h�}�l�[�W���[

    [SerializeField, Header("Correct�`�F�b�N")]
    private Answer_checker ans;

    [SerializeField, Header("���������f�[�^")]
    private AudioClip clip1; //���������f�[�^
    [SerializeField, Header("�s���������f�[�^")]
    private AudioClip clip2; //�s���������f�[�^

    

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
