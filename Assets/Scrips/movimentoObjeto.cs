using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoObjeto : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Destroy(this, 5.0f);
    }
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
    }
}
