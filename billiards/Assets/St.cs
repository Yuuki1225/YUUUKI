using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class St : MonoBehaviour
{

    //　スタートボタンを押したら実行する
    public void BackGame()
    {
        SceneManager.LoadScene("Title");
    }
}