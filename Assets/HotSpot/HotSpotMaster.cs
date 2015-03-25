using Assets.Helpers;
using UnityEngine;

namespace Assets.HotSpot
{
    public class HotSpotMaster : MonoBehaviour    {        private ClickControl _clickControl;        // Use this for initialization        void Start ()        {            _clickControl = new ClickControl();        }        // Update is called once per frame        void Update ()        {        }

        public void Register(Hotspot newSpot)
        {
        
        }

        public void DeRegister(Hotspot dead)
        {
        
        }    }
}