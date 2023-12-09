using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1 : MonoBehaviour
{
    public Camera mainCamera = default; //���C���J����
    public Camera subCamera1 = default; //�T�u�J����1
    public Camera subCamera2 = default; //�T�u�J����2
    void Start()
    {
        //���C���J������ݒ�
        mainCamera = Camera.main;
        //���C���J������L��������
        ActiveMainCamera();
    }

    void Update() { }

    //�֐��F���C���J������L����
    public void ActiveMainCamera()
    {
        subCamera1.gameObject.SetActive(false);
        subCamera2.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);
    }

    //�֐��F�T�u�J����1��L����
    public void ActiveSubCamera1()
    {
        mainCamera.gameObject.SetActive(false);
        subCamera2.gameObject.SetActive(false);
        subCamera1.gameObject.SetActive(true);
    }

    //�֐��F�T�u�J����2��L����
    public void ActiveSubCamera2()
    {
        mainCamera.gameObject.SetActive(false);
        subCamera1.gameObject.SetActive(false);
        subCamera2.gameObject.SetActive(true);
    }
}

