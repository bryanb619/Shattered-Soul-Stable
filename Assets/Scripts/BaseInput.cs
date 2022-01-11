using UnityEngine;
using UnityEngine.EventSystems;

public class BaseInput: BaseInputModule
{
    public GameObject m_TargetObject;

    public override void Process()
    {
        if (m_TargetObject == null)
            return;
        ExecuteEvents.Execute(m_TargetObject, new BaseEventData(eventSystem), ExecuteEvents.moveHandler);
    }
}