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
        // アクティブ化
        panel.SetActive(true);

        // データをセット
        foodName.text = foodData.foodName;
        foodExplanation.text = foodData.foodExplanation;
        foodCountry.sprite = foodData.foodCountryImage;
        foodImage.sprite = foodData.foodImage;

        // プレイヤーの動きを止める
        playerMove.is_move = false;
    }

    public void ClosePanel()
    {
        // パネルを閉じる
        panel.SetActive(false);

        // プレイヤーの動きを戻す
        playerMove.is_move = true;
    }

    private void Update()
    {
        // 停止中、エンターキーを押下して再開
        if (Input.GetKey(KeyCode.Return) && playerMove.is_move == false)
        {
            ClosePanel();
        }
    }
}
