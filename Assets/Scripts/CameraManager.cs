using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public float leftLimit = 0.0f;      // ���� ��ũ�� ����
    public float rightLimit = 0.0f;     // ������ ��ũ�� ���� 
    public float topLimit = 0.0f;       // �� ��ũ�� ���� 
    public float bottomLimit = 0.0f;    // �Ʒ� ��ũ�� ����

    public GameObject subScreen;        // ���� ��ũ��

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            // ī�޶��� ��ǥ ����
            float x = player.transform.position.x;
            float y = player.transform.position.y;
            float z = transform.position.z;
            // ���� ���� ����
            
            // �� ���� �̵� ���� ����
            if (x < leftLimit)
            {
                x = leftLimit;
            }
            else if (x > rightLimit)
            {
                x = rightLimit;
            }
            // ���� ���� ����            
            
            // �� �Ʒ��� �̵� ���� ����
            if (y < bottomLimit)
            {
                y = bottomLimit;
            }
            else if (y > topLimit)
            {
                y = topLimit;
            }
            // ī�޶� ��ġ�� Vector3 �����
            Vector3 v3 = new Vector3(x, y, z);
            transform.position = v3;

            // ���� ��ũ�� ��ũ��
            if (subScreen != null)
            {
                y = subScreen.transform.position.y;
                z = subScreen.transform.position.z;
                Vector3 v = new Vector3(x * 0.5f, y, z);
                subScreen.transform.position = v;
            }
        }
    }
}
