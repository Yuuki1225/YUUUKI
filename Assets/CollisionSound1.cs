using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound1 : MonoBehaviour
{
    // �Ԃ��������̉�
    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // �Ԃ��������ɉ���炷
    void OnCollisionEnter(Collision col)
    {
        AudioSource.PlayClipAtPoint(se, transform.position);
    }
}