using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivareDeactivate : MonoBehaviour
{
    public GameObject inputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivateAndDeactivate()
    {
        //if(inputField.activeInHierarchy)
        //{
        //    inputField.SetActive(false);
        //}
        //else
        //{
        //    inputField.SetActive(true);
        //}
        inputField.SetActive(!inputField.activeInHierarchy);
    }
}
