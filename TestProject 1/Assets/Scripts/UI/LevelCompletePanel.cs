using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompletePanel : MonoBehaviour
{
    public Button ExitButton;
    public Button RestartButton;

    // Start is called before the first frame update
    void Start()
    {
        EventCenter.Instance.AddEventListener("OnMineTimeUp", () => { 
            this.gameObject.SetActive(true);
        });

        ExitButton.onClick.AddListener(() => {
            this.gameObject.SetActive(false);
            LevelManager.Instance.ExitLevel();
        });
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
