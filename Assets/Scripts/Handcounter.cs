using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class Handcounter : MonoBehaviour
{
    ActionBasedController controller;
    Hand hand;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
        hand.setGrip(controller.selectAction.action.ReadValue<float>());
        hand.SetTrigger(controller.selectAction.action.ReadValue<float>());
    }
}
