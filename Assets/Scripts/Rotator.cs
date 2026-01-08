using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void LateUpdate()
    {
         transform.Rotate(new Vector3(15,45,45) * Time.deltaTime);

        
    }
}
