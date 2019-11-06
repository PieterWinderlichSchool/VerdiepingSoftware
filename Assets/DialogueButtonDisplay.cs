using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueButtonDisplay : MonoBehaviour
{
    [SerializeField]
    private DialogueOBJ _Dialogue;

    
    public List<Button> dialogueButtons = new List<Button>();
    // Start is called before the first frame update
    void Start()
    {
        

    }

    public void UpdateTextOptions(int index , Transform parent, int responseIndex)
    {
        for (int i = 0; i < _Dialogue.messages[index].responses.Length; i++)
        {
            
            Instantiate(dialogueButtons[_Dialogue.messages[index].responses[i].ResponseNumber], parent);
            
        }
    }

    // Update is called once per frame

}
