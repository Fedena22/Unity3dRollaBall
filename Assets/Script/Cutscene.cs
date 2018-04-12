using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour {
    // Main Camera on my FPSController object
    public Camera camera1;

    // CutScene Camera with flyover animation
    public Camera camera2;

    // Public variable is set elsewhere in the game. It is used to trigger the cutscene and then immediately turned off on the first pass here in update
    public static bool AllowIntroCutScene = false;


    void Update()
    {
        if (AllowIntroCutScene)
        {
            camera2.GetComponent<Animator>().enabled = true;
            camera1.gameObject.SetActive(false);
            camera2.gameObject.SetActive(true);
            StartCoroutine(PlayOpeningSequence());
            AllowIntroCutScene = false;
        }
    }

    IEnumerator PlayOpeningSequence()
    {
        // The flyover animation is 53 seconds long. Once this time lapses, control is returned to the MainCamera
        yield return new WaitForSeconds(53);
        camera1.gameObject.SetActive(true);
        camera2.gameObject.SetActive(false);

    }


}
