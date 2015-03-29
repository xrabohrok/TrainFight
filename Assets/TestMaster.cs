using Assets.HotSpot;
using UnityEngine;

namespace Assets
{
    [RequireComponent(typeof(HotSpotMaster))]
    public class TestMaster : MonoBehaviour
    {

        private HotSpotMaster _slaveDriver;

        // Use this for initialization
        public void Start ()
        {
            _slaveDriver = this.gameObject.GetComponent<HotSpotMaster>();
            if (_slaveDriver == null)
                throw new System.NullReferenceException();
        }
	
        // Update is called once per frame
        public void Update () {
            _slaveDriver.Update();
        }
    }
}
