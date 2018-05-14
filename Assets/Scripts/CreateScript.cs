using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScript : MonoBehaviour
{

    public GameObject Street1;
    public GameObject Street2;

    float border = -90f;
    bool check = false;

    void Update()
    {
        if (transform.position.z > border)
        {
            MoveStreet();
        }
    }

    void MoveStreet()
    {
        if (check == false){
        //Street1の移動
        if (Street1.transform.position.z < Street2.transform.position.z)
        {
            Street1.transform.position += new Vector3(0, 0, 190);
            border += 95;
            check = true;
        }
        //Street2の移動
        else
        {
            Street2.transform.position += new Vector3(0, 0, 190);
            border += 95;
        }
        }
        else if(check == true){    
        }
    }
    // Use this for initialization

}
