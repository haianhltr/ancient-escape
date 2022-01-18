using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour
{
    public float currentkey = 0f;
    public float currentKey { get; set; }
    public UnityAction<float> onPicked;
    // Start is called before the first frame update
    void Start()
    {
        currentKey = currentkey;
    }

    public void pickup()
    {

        currentKey += 1;
        // call OnHeal action

        onPicked.Invoke(1);
        
    }
}
