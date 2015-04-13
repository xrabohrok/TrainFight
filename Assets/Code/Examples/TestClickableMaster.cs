using Assets.Code.Clickable;
using UnityEngine;

namespace Assets.Code.Examples
{
    [RequireComponent(typeof(ClickEventDelegator))]
    public class TestClickableMaster : MonoBehaviour
    {

        private ClickEventDelegator _slaveDriver;

        // Use this for initialization
        public void Start ()
        {
            _slaveDriver = this.gameObject.GetComponent<ClickEventDelegator>();
            if (_slaveDriver == null)
                throw new System.NullReferenceException();
        }
	
        // Update is called once per frame
        public void Update () {
            _slaveDriver.Update();
        }
    }
}
