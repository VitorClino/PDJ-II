using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TmPro;

public class GameManager : MonoBehaviour
{
    public float[] lanes = new float[3] { -3.75f, 0f, 3.75f };
    public GameObject[] interativos;

    public static GameManager instance;

    void Start()
    {
        InvokeRepeating(nameof(GerarObjetos), 0.1f, 1.25f);
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }


    private void GerarObjetos()
    {
        int randLane = Random.Range(0, lanes.Length);   
        int randObjX = Random.Range(0, interativos.Length);
        Vector3 novaPos = new Vector3(lanes[randLane], transform.position.y, transform.position.z);
        GameObject clone = Instantiate(interativos[randObjX], novaPos, Quaternion.identity );
        //clone.GetComponent<Movimento Objeto>().speed = Random.Range(0.75f, 2f);
    }
}
