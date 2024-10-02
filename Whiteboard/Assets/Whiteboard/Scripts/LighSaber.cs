using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighSaber : MonoBehaviour
{
    private GameObject blade;
    private Vector3 fullSize;
    // Start is called before the first frame update
    void Start()
    {
        blade = transform.Find("SingleLine-LightSaber").gameObject;
        fullSize = blade.transform.localScale;
        blade.transform.localScale = new Vector3(fullSize.x, 0, fullSize.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(blade.transform.localScale.y < fullSize.y)
        {
            blade.transform.localScale += new Vector3(0, 0.0001f, 0);
        }
    }
}
