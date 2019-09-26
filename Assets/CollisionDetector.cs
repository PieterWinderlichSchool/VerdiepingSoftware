using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {

	private CameraPositionUpdater updater;
	private CameraPositions positioner;
	private GameStatusUpdater GUpdate;
    private InputManager inMang;
    

    private bool inRangeOfConv = false;
    private bool inRangeOfCom = false;
    private bool inRangeOfCin = false;


	void Start (){
        updater = GameObject.Find("MainCamera").GetComponent<CameraPositionUpdater>();
        positioner = GameObject.Find("MainCamera").GetComponent<CameraPositions>();
        GUpdate = new GameStatusUpdater();
        inMang = GetComponent<InputManager>(); // new InputManager();
        Debug.Log("debugger");
    }

    void Update()
    {
        inMang.MyUpdate();
        //Debug.Log(inRangeOfCom);
    }

    void OnTriggerStay(Collider other) {
        Debug.Log(other.tag);
        switch (other.tag)
        {
            case "NPC":
                inRangeOfConv = true;
                Debug.Log("NPC: " + inRangeOfConv);
                break;
            case "ENEMY":
                inRangeOfCom = true;
                break;
            case "CINEMATICSTARTINGPOINT":
                inRangeOfCin = true;
                break;

        }
	}
    private void OnTriggerExit(Collider other)
    {
        switch (other.tag)
        {
            case "NPC":
                inRangeOfConv = false;
                break;
            case "ENEMY":
                inRangeOfCom = false;
                break;
            case "CINEMATICSTARTINGPOINT":
                inRangeOfCin = false;
                break;
        }
    }


    public bool GetCinBool()
    {
        return inRangeOfCin;
    }
    public void SetCinBool(bool status)
    {
        inRangeOfCin = status;

    }
    public bool GetConvBool()
    {
        return inRangeOfConv;
    }
    public void SetConvBool(bool status)
    {
        inRangeOfConv = status;
    }
    public bool GetComBool()
    {
        return inRangeOfCom;
    }
    public void SetComBool(bool status)
    {
        inRangeOfCom = status;
    }




}

