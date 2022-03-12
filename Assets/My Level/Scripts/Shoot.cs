using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _mine; // ���� ����
    [SerializeField] private Transform _mineSpawnPlace; // �����, ��� ��������� ����

    private void Update()
    {
          
        if (Input.GetKey("Mouse0"))
        {
            Instantiate(_mine, _mineSpawnPlace.position, _mineSpawnPlace.rotation);
            
        }
    }
}