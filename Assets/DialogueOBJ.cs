using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue" , menuName = "Dialogue/New Dialogue")]
[System.Serializable]
public class DialogueOBJ : ScriptableObject 
{


    public int npcID;
    public string npcName;
    public Message[] messages;
}

[System.Serializable]
public class Message
{
    public Sequence[] textSequence;
    public bool endsInteraction;
    public Response[] responses;
}

[System.Serializable]
public class Response
{
    public int ResponseNumber;
    public int next;
    public string ButtonText;
    public string reply;
    public string prereq;
    public string trigger;

}

[System.Serializable]
public class Sequence {
    public string text;
    public int waitTime;
    public bool hasReaction;
    public string[] Reactions;
}
