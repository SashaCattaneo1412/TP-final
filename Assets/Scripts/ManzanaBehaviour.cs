using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManzanaBehaviour : MonoBehaviour
{
   
    float posX;
    float posZ;
    public GameObject manzana;
    // Start is called before the first frame update
    void Start()
    {
      //  posX = Random.Range(12.4f, 12.33f);
        //posZ = Random.Range(-12.35f, -12.39f);
        //manzana.transform.position = new Vector3(posX, 0.31f, posZ);
        Vector3 position = new Vector3(Random.Range(-12.35f, 12.4f), 0, Random.Range(-12.39f, 12.33f));
        Instantiate(manzana, position, Quaternion.identity);
    }

    // Update is called o76ynce per frame
    void Update()
    {

    }

}