﻿using UnityEngine;
using Zenject;
using Common;

namespace InputSystem
{
    public class KeyboardInput : IInputComponent
    {
        private IInputService inputService;

        public KeyboardInput()
        {
            Debug.Log("<color=green>[KeyboardInput] Created:</color>");
        }

        public void OnInitialized(IInputService inputService)
        {
            this.inputService = inputService;
        }

        public void OnTick()
        {
            DecideDirection();
        }

        void DecideDirection()
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Debug.Log("[InputComponent] Left");
                inputService.PassDirection(Directions.LEFT);
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                Debug.Log("[InputComponent] Right");
                inputService.PassDirection(Directions.RIGHT);
            }

            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("[InputComponent] Down");
                inputService.PassDirection(Directions.DOWN);
            }
            else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("[InputComponent] Up");
                inputService.PassDirection(Directions.UP);
            }
        }
    }
}