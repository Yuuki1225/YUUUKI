using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//�@�Q�[���I���{�^��������������s����
public class Canva : MonoBehaviour
{
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