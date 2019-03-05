using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulatorAngles : MonoBehaviour
{
    public GameObject[] Points =new GameObject[6];
    public float[] Angles = new float[] {0,10,20,30,40,50 };
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Points[0].transform.localEulerAngles = new Vector3(0, Angles[0], 0);
        Points[1].transform.localEulerAngles = new Vector3(0, 0, Angles[1]);
        Points[2].transform.localEulerAngles = new Vector3(0, 0, Angles[2]);
        Points[3].transform.localEulerAngles = new Vector3(0, 0, Angles[3]);
        Points[4].transform.localEulerAngles = new Vector3(Angles[4], 0, 0);
        //Points[5].transform.localEulerAngles = new Vector3(0,-180, Angles[5]);
        Points[5].transform.Rotate(0, 0, Angles[5]);
    }
}
