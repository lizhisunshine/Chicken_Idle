using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterlevelButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(LevelManager.Instance.EnterLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
