using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public Collider2D attackCollider;
    //public float mineTime = 0.3f;
    public float collTime = 0.04f;

    public Vector3 TouchPoint;

    private void Awake()
    {
        attackCollider = GetComponent<CircleCollider2D>();
    }

    private void OnEnable()
    {
        //if (GameManager.instance == null) return;
    }

    private void OnDisable()
    {
        attackCollider.enabled = false;
        StopAllCoroutines();
    }

    private void Start()
    {
        StartCoroutine(Mine());
    }

    private void Update()
    {
        //每帧检测玩家手指位置并跟随
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            TouchPoint = Camera.main.ScreenToWorldPoint(touch.position);
            this.transform.position = new Vector3(TouchPoint.x,TouchPoint.y,0);
        }
        else
        {
            this.transform.position = new Vector3 (10000, 0, 0);
        }
    }

    private IEnumerator Mine()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(GameManager.instance.mineTime);
            attackCollider.enabled = true;
            yield return new WaitForSeconds(collTime);
            attackCollider.enabled = false;
            yield return null;
        }
    }
}
