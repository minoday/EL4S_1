using UnityEngine;

public class SetClearData : MonoBehaviour
{
    [SerializeField] ClearData clearData;
    [SerializeField] Player_Test playerTest;
    public void SetData()
    {   // ステージデータに正答数の情報を入れる
        clearData.stageData[clearData.selectStage].n_correct = playerTest.Score;
    }
}
