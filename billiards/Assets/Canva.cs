using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//　ゲーム終了ボタンを押したら実行する
public class Canva : MonoBehaviour
{
    //　ゲーム終了ボタンを押したら実行する
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