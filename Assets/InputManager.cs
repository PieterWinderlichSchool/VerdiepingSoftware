using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour  
{
    private GameStatusUpdater status;
    private CameraPositionUpdater updater;
    private GameStatusUpdater GUpdate;
    private CameraPositions positioner;
    private CollisionDetector colDetector;
    public Action StartConvo;
    
    public void Start()
    {
        GUpdate = new GameStatusUpdater();

    }

    public void MyUpdate()
    {
        status = new GameStatusUpdater();
        colDetector = GetComponent<CollisionDetector>();
        
        if(positioner == null)
        {
            positioner = GameObject.Find("MainCamera").GetComponent<CameraPositions>();
        }
        if(updater == null)
        {
            updater = GameObject.Find("MainCamera").GetComponent<CameraPositionUpdater>();
        }


        if(GameStatusUpdater.gStatus == GameStatuses.Playable)
            if(colDetector.GetConvBool() == true)
        if (Input.GetKeyDown(KeyCode.E)){
                    StartConvo();

            updater.SetCameraToInteraction(0);
                GameStatusUpdater.gStatus = GameStatuses.Conversation;
        }
    }







}