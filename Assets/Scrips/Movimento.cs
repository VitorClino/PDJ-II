using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{

    private float[] lanes = new float[3] { -3.75f, 0f , 3.75f };

    private int _currentLane = 0;
    private float vida = 3;
    private int moeda = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoverEsquerda();
        }
        if (Input.GetKeyDown(KeyCode.D))
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
    void OnTriggerEnter(Collider objetoColidido)
    {
        if (objetoColidido.CompareTag("Enemy"))
        {
            vida--;
            Debug.Log(vida);
        }
                
        if (objetoColidido.CompareTag("Coin"))
        {
            moeda++;
            Debug.Log(moeda);
        }
        Destroy(objetoColidido.gameObject);
    }
}
