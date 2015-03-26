using Assets.Helpers;using System.Collections.Generic;using UnityEngine;namespace Assets.HotSpot{    /// <summary>
    /// Composite me into master controllers.  Remember to set the Input button names
    /// </summary>    public class HotSpotMaster     {        private ClickControl _clickControl;        private List<IHotspot> _membersList;        public List<string> InputVirtualButtonNames;        public HotSpotMaster()
        {
            Initialize();

            InputVirtualButtonNames = new List<string>();
        }

        public HotSpotMaster(List<string> inputs)
        {
            Initialize();

            InputVirtualButtonNames = inputs;
        }

        private void Initialize()
        {
            _clickControl = new ClickControl();
            _membersList = new List<IHotspot>();
        }

        /// <summary>
        /// Call this when you need your things reacting to being moused
        /// </summary>        public void Update ()        {            var hoveredThing = _clickControl.ThingHovered.GetComponent<IHotspot>();            if (hoveredThing != null)            {                hoveredThing.HoverReaction();                foreach (var buttonNames in InputVirtualButtonNames)                {                    var pushed = Input.GetButton(buttonNames);                    if (pushed)                    {                        hoveredThing.ClickReaction();                    }                    break;                }            }        }        public void Register(IHotspot newSpot)        {            _membersList.Add(newSpot);        }        public void DeRegister(IHotspot dead)        {            _membersList.Remove(dead);        }    }}