using UnityEngine;

[CreateAssetMenu(menuName = "StageData")]
public class StageData : ScriptableObject
{
    public int selectStage; // 選択中のステージ
    public int n_questions = 0;
    public int n_correct = 0;
}
