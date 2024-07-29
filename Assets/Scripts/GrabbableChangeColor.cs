using BNG;
using UnityEngine;

namespace VR.CustomScene
{
    /// <summary>
    /// This component is designed to change the material when taking and releasing an object
    /// </summary>
    public class GrabbableChangeColor : GrabbableEvents
    {
        //assigned material
        [Header ("assigned material")][SerializeField] private Material _materialOnGrab;
        private Material _defoltMaterial;
        private MeshRenderer _meshRenderer;

        private void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
            _defoltMaterial = _meshRenderer.sharedMaterial;
        }

        public override void OnGrab(Grabber grabber) => _meshRenderer.sharedMaterial = _materialOnGrab;

        public override void OnRelease() => _meshRenderer.sharedMaterial = _defoltMaterial;
    }
}
