using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimesUpdater : MonoBehaviour
{
    [SerializeField]GameObject cubo;
    Game game;
    float prev1;
    // Update is called once per frame
    private void Start()
    {
        game = FindObjectOfType<Game>();
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        

        if (cubo.transform.localScale.y < game.timesPlayed)
        {
            prev1 = game.timesPlayed;
            cubo.transform.localScale += new Vector3(0f, 1f, 0f);
            yield return new WaitForSeconds(time);
            
        }
    }
    private void Update()
    {
        StartCoroutine(ExecuteAfterTime(2));
        if (game.timesPlayed != prev1)
        {
            cubo.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
