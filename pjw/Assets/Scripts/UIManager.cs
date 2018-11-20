using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using VRTK;

public class UIManager : MonoBehaviour {
    private Transform factoryIn;
    private Transform factoryOut;
    private Transform door;
    private Transform list;
    public Transform listPanel;
    public Transform Player;
    public Transform doorPoint;
    public Transform factoryInPoint;
    public Transform factoryOutPoint;
    private void Awake()
    {
        listPanel.gameObject.SetActive(false);
        transform.Find("FactoryIn").GetComponent<UIEventListener>().onButtonClick += FactoryIn;
        transform.Find("FactoryOut").GetComponent<UIEventListener>().onButtonClick += FactoryOut;
        transform.Find("Door").GetComponent<UIEventListener>().onButtonClick += Door;
        transform.Find("List").GetComponent<UIEventListener>().onButtonClick += SetList;
    }
    /// <summary>
    /// 在屏幕中显示清单列表
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="eventData"></param>
    private void SetList(GameObject sender, PointerEventData eventData)
    {
        listPanel.gameObject.SetActive(true);
    }
    /// <summary>
    /// 去门口
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="eventData"></param>
    private void Door(GameObject sender, PointerEventData eventData)
    {
        Debug.Log("点到门了");
        PlayerMove(doorPoint.position);
    }
    /// <summary>
    /// 到工厂外面
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="eventData"></param>
    private void FactoryOut(GameObject sender, PointerEventData eventData)
    {
        PlayerMove(factoryOutPoint.position);
    }
    /// <summary>
    /// 进入到工厂里面
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="eventData"></param>
    private void FactoryIn(GameObject sender, PointerEventData eventData)
    {
        PlayerMove(factoryInPoint.position);
    }
    /// <summary>
    /// 主角移动
    /// </summary>
    /// <param name="position"></param>
    private void PlayerMove(Vector3 position)
    {
        Player.position = position;
    }
}
