using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeGameUpdater : MonoBehaviour
{
    [SerializeField] GameObject cubo;
    Game game;
    int prev3;
    // Update is called once per frame
    private void Start()
    {
        game = FindObjectOfType<Game>();
    }
    IEnumerator ExecuteAfterTime(float time)
    {


        if (cubo.transform.localScale.y < game.GameType)
        {
            prev3 = game.GameType;
            cubo.transform.localScale += new Vector3(0f, 1f, 0f);
            yield return new WaitForSeconds(time);
         
        }
    }
    private void Update()
    {
        StartCoroutine(ExecuteAfterTime(2));
        if (game.GameType != prev3)
        {
            cubo.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
