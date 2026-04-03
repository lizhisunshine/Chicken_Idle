using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponResources : MonoBehaviour
{

    public List<GameObject> WeaponList = new();


    private void OnEnable()
    {   
        if (WeaponManager.instance == null) return;
        PlayAnim();
    }

    private void OnDisable()
    {
        if (WeaponManager.instance == null) return;
        this.transform.eulerAngles = Vector3.zero;
        WeaponList[WeaponManager.instance.WeaponIndex].SetActive(false);
    }

    public void PlayAnim()
    {
        WeaponList[WeaponManager.instance.WeaponIndex].SetActive(true);
        if (Random.Range(1, 3) == 1)
        {
            this.transform.position += new Vector3(-0.22f, 0.22f, 0f);

            this.transform.eulerAngles=new Vector3(0,180,0);
            this.transform.DOLocalRotate(new Vector3(0f, 180f, 45f), GameManager.instance.mineTime).OnComplete(() => {
                ObjectPool.instance.Release(this.gameObject);
            });
        }
        else 
        {
            this.transform.position += new Vector3(0.22f, 0.22f, 0f);

            this.transform.eulerAngles  = Vector3.zero;
            this.transform.DOLocalRotate(new Vector3(0f, 0f, 45f), GameManager.instance.mineTime).OnComplete(() => {
                ObjectPool.instance.Release(this.gameObject);
            });
        }
        
    }
}
