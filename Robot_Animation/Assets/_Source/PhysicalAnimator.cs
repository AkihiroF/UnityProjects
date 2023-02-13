using UnityEngine;

namespace _Source
{
    [RequireComponent(typeof(ConfigurableJoint))]
    public class PhysicalAnimator : MonoBehaviour
    {
        [SerializeField] private Transform target;
        private ConfigurableJoint _joint;
        private Quaternion _startRotation;
        void Start()
        {
            _joint = GetComponent<ConfigurableJoint>();
            _startRotation = target.localRotation;
        }

        private void FixedUpdate()
        {
            _joint.targetRotation = Quaternion.Inverse(target.localRotation) * _startRotation;
        }
    }
}
