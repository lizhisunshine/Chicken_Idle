using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.Events;

//事件中心
public class EventCenter
{
    public static EventCenter instance;

    //创建事件列表用来存储事件
    public Dictionary<string,IEventInfo> EventDic  = new Dictionary<string, IEventInfo>();

    //利用属性实现单例
    public static EventCenter Instance
    { 
        get 
        {
            if (instance == null)
            {
                instance = new EventCenter();
            }
            return instance; 
        }
    }

    //添加订阅消息方法
    public void AddEventListener(string name,UnityAction action)
    {
        
        if (EventDic.ContainsKey(name))
        {
            (EventDic[name] as EventInfo).actions += action;
        }
        else 
        {
            EventDic.Add(name, new EventInfo(action));
        }
    }

    //通知消息方法
    public void EventTigger(string name)
    {
        if (EventDic.ContainsKey(name))
        {
            if ((EventDic[name] as EventInfo).actions != null)
            {
                (EventDic[name] as EventInfo).actions.Invoke();
            }
        }
    }

    //删除订阅信息的方法
    public void RemoveEventListener(string name,UnityAction action)
    {
        if (EventDic.ContainsKey(name))
        {
            (EventDic[name] as EventInfo).actions -= action;
        }
    }

    public void AddEventListener<T>(string name, UnityAction action)
    {

        if (EventDic.ContainsKey(name))
        {
            (EventDic[name] as EventInfo).actions += action;
        }
        else
        {
            EventDic.Add(name, new EventInfo(action));
        }
    }

    //通知消息方法
    public void EventTigger<T>(string name)
    {
        if (EventDic.ContainsKey(name))
        {
            if ((EventDic[name] as EventInfo).actions != null)
            {
                (EventDic[name] as EventInfo).actions.Invoke();
            }
        }
    }

    //删除订阅信息的方法
    public void RemoveEventListener<T>(string name, UnityAction action)
    {
        if (EventDic.ContainsKey(name))
        {
            (EventDic[name] as EventInfo).actions -= action;
        }
    }
}

public interface IEventInfo
{ 
    
}

public class EventInfo : IEventInfo
{
    public UnityAction actions;
    public EventInfo(UnityAction action)
    {
        actions += action;
    }
}

public class EventInfo<T> : IEventInfo
{
    public UnityAction<T> actions;
    public EventInfo(UnityAction<T> actions)
    {
        this.actions = actions;
    }   
}

