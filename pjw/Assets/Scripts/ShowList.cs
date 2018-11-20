using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShowList : MonoBehaviour {
    private string message;
    private GameObject[] parts;
    private Text content;
    private int index = 0;
    private GameObject currentObject;
    private void Awake()
    {
        content = GetComponentInChildren<Text>();
        GameObject.Find("Exit").GetComponent<UIEventListener>().onButtonClick += ExitButtonClick;
    }

    private void ExitButtonClick(GameObject sender, PointerEventData eventData)
    {
        gameObject.SetActive(false);
    }
    /// <summary>
    /// 当对象每次被启用时，显示场景中有多少设备
    /// </summary>
    private void OnEnable()
    {
        //在每次启用时将原来的数据清空
        message = "";
        index = 0;
        parts = GameObject.FindGameObjectsWithTag("Parts");
        //记录下数组中的第一个元素
        currentObject = parts[0];
        for (int i = 0; i < parts.Length; i++)
        {
            //如果两个元素的名字相同，那么认为这是同一个对象
            if (parts[i].name == currentObject.name)
            {
                index += 1;
            }
            else
            {
                message += currentObject.name + ";有" + index + "个\n";
                currentObject = parts[i];
                index = 1;
            }
        }
        ShowMessage();
    }
    /// <summary>
    /// 显示设备的名称
    /// </summary>
	private void ShowMessage()
    {
        if (message == null) return;
        content.text = message;
    }
}
