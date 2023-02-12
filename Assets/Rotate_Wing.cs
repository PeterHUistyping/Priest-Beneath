using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Wing : MonoBehaviour
{
    [SerializeField]float rotateSpeed=60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.localEulerAngles=new Vector3(Mathf.PingPong(Time.time*rotateSpeed,60)-30,Mathf.PingPong(Time.time*rotateSpeed,60)-30,0);
    }
}
