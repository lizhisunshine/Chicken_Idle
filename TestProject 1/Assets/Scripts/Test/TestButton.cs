using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TestButton : MonoBehaviour
{
    [SerializeField] GameObject obj;
    bool isBig = false;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(RevoluteObj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RevoluteObj()
    {
        obj.transform.DOScale(new Vector3(
            isBig ? 1.0f : 6f,
            isBig ? 1.0f : 6f,
            1
            ),0.4f);
        isBig = !isBig;
    }
}
