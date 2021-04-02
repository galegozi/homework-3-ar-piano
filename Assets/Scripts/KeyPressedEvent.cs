using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPressedEvent : MonoBehaviour
{
    public Text keyName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pressed(GameObject p)
    {
        keyName.text = p.name;
    }

    public void Released()
    {
        keyName.text = string.Empty;
    }
}
