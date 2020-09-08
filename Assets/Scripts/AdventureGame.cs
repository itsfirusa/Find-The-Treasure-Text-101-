using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
     [SerializeField] Text textComponent;
     [SerializeField] State startingState;

    string[] daysOfTheWeek = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(daysOfTheWeek[3]);
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextState = state.GetNextState();

        for (int index = 0; index < nextState.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextState[index];
            }

        }

      /*  if(Input.GetKeyDown(KeyCode.Alpha1))  //Alpha1-> 1
        {
            state = nextState[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))  
        {
            state = nextState[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))  
            {
                state = nextState[2];
            } */

        textComponent.text = state.GetStateStory();

    }
}
