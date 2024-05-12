using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class titleScript : MonoBehaviour
{
    [HideInInspector]public int m_nowSelect;
    [SerializeField] private string m_nextSceneName;
    private float m_oldHorizontal;
    [SerializeField] private Color32 m_SelectColor;
    [SerializeField] private Color32 m_unSelectColor;
    [SerializeField] private GameObject m_toSelectScene;
    [SerializeField] private GameObject m_toFinishGame;

    private Image m_toNextSceneUIColor;
    private Image m_toFinishUIColor;


    // Start is called before the first frame update
    void Start() {
        m_toNextSceneUIColor=m_toSelectScene.GetComponent<Image>();
        m_toFinishUIColor=m_toFinishGame.GetComponent<Image>();

        m_SelectColor.a = 255;
        m_unSelectColor.a = 255;

    }

    // Update is called once per frame
    void Update() {
        if(Input.GetAxis("Horizontal")>0 && m_oldHorizontal <= 0) {
            m_nowSelect++;
        }
        if(Input.GetAxis("Horizontal") < 0 && m_oldHorizontal >= 0) {
            m_nowSelect--;
            if (m_nowSelect < 0) {
                m_nowSelect = 1;
            }
        }
        m_nowSelect %= 2;

        switch (m_nowSelect) {
            case 0:
                m_toNextSceneUIColor.color = m_SelectColor;
                m_toFinishUIColor.color = m_unSelectColor;
                break;
            case 1:
                m_toNextSceneUIColor.color = m_unSelectColor;
                m_toFinishUIColor.color = m_SelectColor;
                break;
            default:
                break;
        }




        if (Input.GetButton("Submit")) {
            switch (m_nowSelect) {
                case 0:
                    LoadScene();
                    break;
                case 1:
                    EndGame();
                    break;
                default:
                    break;
            }
            
        }


        m_oldHorizontal = Input.GetAxis("Horizontal");
    }


    public void LoadScene() {
        SceneManager.LoadScene(m_nextSceneName);
    }
    public void EndGame() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
            Application.Quit();//ゲームプレイ終了
#endif
    }

}
