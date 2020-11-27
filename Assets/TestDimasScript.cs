using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDimasScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform RightHandObj;
    private Animator animator;
    private float value = 0.0f;
    
    void Start()
    {
        animator = GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RightHandObj.transform.position = new Vector3(value, 0, 0);
        value += 0.1f;
    }

    void OnAnimatorIK(int layerIndex)
    {
      
    }
}
