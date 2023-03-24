using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimTION : MonoBehaviour
{
    public Transform Parent;
    public RectTransform child;
    public GameObject btnprefab;
    private void Start()
    {
        Parent.DOMoveX(200, 1.5f).From(-400).OnComplete(extendchild);
    }
    public void extendchild()
    {
        child.DOSizeDelta(new Vector2(700, 300), 1).SetEase(Ease.OutBack).OnComplete(fill);
    }
    public async void fill()
    {
         for (int i = 0; i < 5; i++)
         {
        

         }
    }

}