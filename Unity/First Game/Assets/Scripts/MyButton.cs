using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButton : MonoBehaviour
{
    public GameObject player;

    public static double vertical, parallel = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.Translate((float)parallel, (float)vertical, 0);
    }

    public void RightButton()
    {
        parallel -= 0.2;
    }

    public void LeftButton()
    {
        parallel += 0.2;
    }
}
