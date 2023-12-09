using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //�J�������i�[����ϐ�
    public Camera Camera;
    public Camera subCamera;
    public Camera subsubCamera;

    //�L�����o�X���i�[
    public GameObject Canvas;

    // Use this for initialization
    void Start()
    {

        //���߂̓T�u�J�������I�t�ɂ��Ă���
        subCamera.enabled = false;
        subsubCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�{�^�������������̏���
    public void PushButton()
    {
        //�����T�u�J�������I�t��������
        if (!subsubCamera.enabled)
        {
            //�T�u�J�������I���ɂ���
            subCamera.enabled = true;

            //�J�������I�t�ɂ���
            Camera.enabled = false;

            //�L�����o�X���f���J�������T�u�J�����I�u�W�F�N�g�ɂ���
            Canvas.GetComponent<Canvas>().worldCamera = subCamera;
        }
        else if(!Camera.enabled)
        {

            subsubCamera.enabled = true;
            subCamera.enabled = false;
            Canvas.GetComponent<Canvas>().worldCamera = subsubCamera;

        }
 
        else
        {
            //�T�u�J�������I�t�ɂ���
            subsubCamera.enabled = false;

            //�J�������I���ɂ���
            Camera.enabled = true;

            //�L�����o�X���f���J�������J�����I�u�W�F�N�g�ɂ���
            Canvas.GetComponent<Canvas>().worldCamera = Camera;
        }
    }
}