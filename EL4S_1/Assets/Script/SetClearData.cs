using UnityEngine;

public class SetClearData : MonoBehaviour
{
    [SerializeField] ClearData clearData;
    [SerializeField] Player_Test playerTest;
    public void SetData()
    {   // �X�e�[�W�f�[�^�ɐ������̏�������
        clearData.stageData[clearData.selectStage].n_correct = playerTest.Score;
    }
}
