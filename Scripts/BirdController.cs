using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    public int posStart = -8;
    public int posEnd = -7;
    public int yPos = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(posStart, posEnd, Mathf.PingPong(Time.time, 1)), yPos, 0);
    }
}
