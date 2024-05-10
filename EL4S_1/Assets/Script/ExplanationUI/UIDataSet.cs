using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDataSet : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Text foodName;
    [SerializeField] Text foodExplanation;
    [SerializeField] Image foodCountry;
    [SerializeField] Image foodImage;

    [SerializeField] Player_move playerMove;
    [SerializeField] public FoodData foodData;

    public void DisplayPanel()
    {
        // �A�N�e�B�u��
        panel.SetActive(true);

        // �f�[�^���Z�b�g
        foodName.text = foodData.foodName;
        foodExplanation.text = foodData.foodExplanation;
        foodCountry.sprite = foodData.foodCountryImage;
        foodImage.sprite = foodData.foodImage;

        // �v���C���[�̓������~�߂�
        playerMove.is_move = false;
    }

    public void ClosePanel()
    {
        // �p�l�������
        panel.SetActive(false);

        // �v���C���[�̓�����߂�
        playerMove.is_move = true;
    }

    private void Update()
    {
        // ��~���A�G���^�[�L�[���������čĊJ
        if (Input.GetKey(KeyCode.Return) && playerMove.is_move == false)
        {
            ClosePanel();
        }
    }
}
