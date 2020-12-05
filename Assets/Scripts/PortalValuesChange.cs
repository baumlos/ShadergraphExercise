using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalValuesChange : MonoBehaviour
{

    public Material mat;

    public float startValue;
    public float endValue;
    public bool start;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            StartCoroutine(LoopThroughValues());
        }
    }

    IEnumerator LoopThroughValues()
    {
        mat.SetFloat("Vector1_D8429BE4", startValue);

        for (float i = startValue; i < endValue; i += 0.1f)
        {
            mat.SetFloat("Vector1_D8429BE4", i);
            yield return null;
        }
        start = false;
    }
}
