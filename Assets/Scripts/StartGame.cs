using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
    public StartingGame StartingGame;
    public Objects Objects;
    public bool isLoaded;
    IEnumerator Start()
    {
        isLoaded = false;
        while (!isLoaded)
        {
            if (Objects != null)
                isLoaded = true;
            yield return null;
        }
        StartingGame = new StartingGame(Objects);
        StartingGame.StartPlayer();
    }
}
public class StartingGame
{
    private Objects objects;
    public StartingGame(Objects objects)
    {
        this.objects = objects;
    }
    public void StartPlayer()
    {

    }
}
