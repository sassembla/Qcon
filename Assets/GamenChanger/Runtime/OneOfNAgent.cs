using UnityEngine;
using UnityEngine.EventSystems;

namespace GamenChangerCore
{
    public class OneOfNAgent : MonoBehaviour, IPointerUpHandler
    {
        public OneOfNCorner parent;
        public void OnPointerUp(PointerEventData eventData)
        {
            Debug.Log("root frame:" + Time.frameCount);
            parent.OnPointerUp(eventData);
        }
    }
}