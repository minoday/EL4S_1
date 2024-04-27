using UnityEngine;

[CreateAssetMenu(menuName ="ClearData")]
public class ClearData : ScriptableObject
{
    public int selectStage; // 選択中のステージ
    public StageData[] stageData;
}
