using Assets.HotSpot;
using UnityEngine;

namespace Assets.Examples
{
    [RequireComponent(typeof(Clickable))]
    public class TestClickableMaster : MonoBehaviour
    {

        private Clickable _slaveDriver;

        // Use this for initialization
        public void Start ()
        {
            _slaveDriver = this.gameObject.GetComponent<Clickable>();
            if (_slaveDriver == null)
                throw new System.NullReferenceException();
        }
	
        // Update is called once per frame
        public void Update () {
            _slaveDriver.Update();
        }
    }
}
