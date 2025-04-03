using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSuccess : MonoBehaviour
{

    public Joint joint1;
    public Joint joint2;
    public AudioSource audio1;
    public AudioSource audio2;

    private bool is_ended = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (joint1 == null && joint2 == null && !is_ended) {
            endgame();
        }
       // Debug.Log(joint1.name);
      //  Debug.Log(joint2.name);

    }
    
    void endgame()
    {
        is_ended = true;
        audio1.Play();
        audio2.Stop();
        Debug.Log("Game End.");
    }
}
