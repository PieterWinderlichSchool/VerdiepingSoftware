using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DialogueDisplay : MonoBehaviour
{
    public TextField textField;
   
    // Start is called before the first frame update
    void Start()
    {

        
        DisplayText("check", 0, 0, 0, 0, this.transform);

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void DisplayText(string text, float xMinAnchor, float xMaxAnchor, float yMinAnchor , float yMaxAnchor, Transform parent)
    {
        textField = new TextField();

    }
}
