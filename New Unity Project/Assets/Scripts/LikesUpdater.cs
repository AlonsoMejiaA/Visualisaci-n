using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LikesUpdater : MonoBehaviour
{
    [SerializeField] GameObject cubo;
    Game game;
    float prev2;
    // Update is called once per frame
    private void Start()
    {
        game = FindObjectOfType<Game>();
    }
    IEnumerator ExecuteAfterTime(float time)
    {


        if (cubo.transform.localScale.y < game.likes)
        {
            prev2 = game.likes;
            cubo.transform.localScale += new Vector3(0f, 1f, 0f);
            yield return new WaitForSeconds(time);

        }
    }
    private void Update()
    {
        StartCoroutine(ExecuteAfterTime(2));
        if (game.likes != prev2)
        {
            cubo.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
