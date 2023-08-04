using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class BackToMainMenu : MonoBehaviour
{
    public ActionBasedController rightHand;
    public InputActionReference sceneChange = null;
    // Start is called before the first frame update
    void Awake()
    {
        sceneChange.action.started += SceneChange;
    }

    void OnDestroy() 
    {
        sceneChange.action.started -= SceneChange;
    }

    // Update is called once per frame
    void Update()
    {
        //if (rightHand.activateAction.action.ReadValue<float>() > 0.5f)
        //{
        //    Debug.Log("trigger pressed");
        //}
    }

    void SceneChange(InputAction.CallbackContext context) 
    {
        SceneManager.LoadScene("OpeningScene");
    }
}
