using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbody;          // Rigidbody2D �� ����
    float axisH = 0.0f;         // �Է�

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D ��������
        rbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ���������� �Է� Ȯ��
        axisH = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        // �ӵ� �����ϱ�
        rbody.velocity = new Vector2(3.0f * axisH, rbody.velocity.y);
    }
}
