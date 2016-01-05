using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {
    public Objects Objects;
    public Control Control;
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
        Control = new Control(Objects);
        Control.Movement();
    }
}
public class Control
{
    private Objects objects;
    public Control(Objects objects)
    {
        this.objects = objects;
    }
    public void Movement()
    {
        Debug.Log("Hallo");
    }
}

