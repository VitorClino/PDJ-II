using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    //public GameObject player, coin, obstaculo;

    private float[] lanes = new float[3] { -3.75f, 0f , 3.75f };

    private int _currentLane = 0;
    private int vida = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoverEsquerda();
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            MoverDireita();
        }
    }
    public void MoverEsquerda()
    {
        _currentLane--;
        if(_currentLane <= 0)
        {
            _currentLane = 0;
        }
        float x = lanes[_currentLane];
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
    public void MoverDireita()
    {
        _currentLane++;
        if (_currentLane >= lanes.Length)
        {
            _currentLane = lanes.Length;
        }
        float x = lanes[_currentLane];
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
