using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{

    //�@�X�^�[�g�{�^��������������s����
    public void StartGame()
    {
        SceneManager.LoadScene("kadai1");
    }
    //�@�Q�[���I���{�^��������������s����
    public void EndGame()
    {
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
		Application.OpenURL("http://www.yahoo.co.jp/");
#else
        Application.Quit();
#endif
    }
}

