using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound1 : MonoBehaviour
{
    // ‚Ô‚Â‚©‚Á‚½Žž‚Ì‰¹
    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // ‚Ô‚Â‚©‚Á‚½Žž‚É‰¹‚ð–Â‚ç‚·
    void OnCollisionEnter(Collision col)
    {
        AudioSource.PlayClipAtPoint(se, transform.position);
    }
}