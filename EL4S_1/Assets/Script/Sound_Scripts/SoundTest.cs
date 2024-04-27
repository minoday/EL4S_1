using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager; //�T�E���h�}�l�[�W���[

    [SerializeField]
    private AudioClip clip1; //�����f�[�^1

    [SerializeField]
    private AudioClip clip2; //�����f�[�^2

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //���N���b�N
        {
            soundManager.Play(clip1); //�T�E���h�}�l�[�W���[���g�p���Č��ʉ��Đ�
        }
        if (Input.GetMouseButtonDown(1)) //�E�N���b�N
        {
            soundManager.Play(clip2); //�T�E���h�}�l�[�W���[���g�p���Č��ʉ��Đ�
        }
    }
}
