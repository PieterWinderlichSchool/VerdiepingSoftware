using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueTreeAmount : MonoBehaviour
{   [SerializeField]
    private List<Button> _ButtonPrefabs = new List<Button>();
    [SerializeField]
    private List<int> _DialogueTree = new List<int>();

    public List<int> dialogueAmounts = new List<int>();
   


    // Start is called before the first frame update
    void Start()
    {

        GameObject.Find("Player").GetComponent<InputManager>().StartConvo += StartConvo;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartConvo()
    {
        for (int i = 0; i < dialogueAmounts.Count; i++)
        {
            for (int j = 0; j < dialogueAmounts[i]; j++)
            {
               
                Button button = Instantiate(_ButtonPrefabs[i], GameObject.Find("DialoguePanel").transform);
            }

        }
    }
}
