using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] GameObject mainBall = null;
    [SerializeField] float power = 0.1f;
    [SerializeField] Transform arrow = null;
    [SerializeField] List<ColorBall> balllist = new List<ColorBall>();

    Vector3 mousePosition = new Vector3();
    Rigidbody mainRigid = null;
    Vector3 mainBallDefaultPosition = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        mainRigid = mainBall.GetComponent<Rigidbody>();
        mainBallDefaultPosition = mainBall.transform.localPosition;
        arrow.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (mainBall.activeSelf == true)
        {
            if (Input.GetMouseButtonDown(0) == true)
            {
                mousePosition = Input.mousePosition;
                arrow.gameObject.SetActive(true);
                Debug.Log("�N���b�N�J�n");
            }

            if (Input.GetMouseButton(0) == true)
            {
                Vector3 position = Input.mousePosition;

                Vector3 def = mousePosition - position;
                float rad = Mathf.Atan2( def.x, def.y);
                float angle = rad * Mathf.Rad2Deg;
                Vector3 rot = new Vector3( 0, angle, 0);
                Quaternion qua = Quaternion.Euler(rot);

                arrow.localRotation = qua;
                arrow.transform.position = mainBall.transform.position;
            }

            if (Input.GetMouseButtonUp(0) == true)
            {
                Vector3 upPosition = Input.mousePosition;

                Vector3 def = mousePosition - upPosition;
                Vector3 add = new Vector3(def.x, 0, def.y);

                mainRigid.AddForce(add * power);

                arrow.gameObject.SetActive(false);

                Debug.Log("�N���b�N�I��");
            }
        }
    }
    //------------------------------------------------------
    ///<summary>
    ///���Z�b�g�{�^���N���b�N�R�[���o�b�N.
    ///</summary>
    //------------------------------------------------------
    public void OnResetButtonClicked()
    {
        //���̒��g������ŏ����Ă���
        mainBall.SetActive(true);
        // ���C���{�[���̑��x�������I�Ƀ[����.
        mainRigid.velocity = Vector3.zero;
        // ���C���{�[���̉�]���x�������I�Ƀ[����.
        mainRigid.angularVelocity = Vector3.zero;
        // ���C���{�[���������ʒu�ɖ߂�.
        mainBall.transform.localPosition = mainBallDefaultPosition;

        foreach(ColorBall ball in balllist)
        {
            ball.Reset();
        }
    }
}
