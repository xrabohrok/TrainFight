using Assets.Helpers;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.HotSpot
{
    /// <summary>
    /// Composite me into master controllers.  Remember to set the Input button names
    /// </summary>
    
    [RequireComponent(typeof(ClickControl))]
    public class Clickable : MonoBehaviour
    {
        private ClickControl _clickControl;

        public List<string> InputVirtualButtonNames;

        public void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            _clickControl = this.gameObject.GetComponent<ClickControl>();
        }

        /// <summary>
        /// Call this when you need your things reacting to being moused
        /// </summary>
        public void Update ()
        {
            IClickable thing = null;
            if(_clickControl.ValidPoint)
                thing = _clickControl.ThingHovered.GetComponent<IClickable>();
            if (thing != null)
            {
                thing.HoverReaction();

                foreach (var buttonNames in InputVirtualButtonNames)
                {
                    var pushed = Input.GetButton(buttonNames);
                    if (pushed)
                    {
                        thing.ClickReaction();
                    }
                    break;
                }
            }
        }
    }
}