using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound1 : MonoBehaviour
{
    // ぶつかった時の音
    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // ぶつかった時に音を鳴らす
    void OnCollisionEnter(Collision col)
    {
        AudioSource.PlayClipAtPoint(se, transform.position);
    }
}