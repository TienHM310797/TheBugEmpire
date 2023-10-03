/// adaption for cylindrical bending by herbst
/// Credit Breyer
/// Sourced from - http://forum.unity3d.com/threads/scripts-useful-4-6-scripts-collection.264161/#post-1777407
using System.Collections.Generic;
namespace UnityEngine.UI.Extensions
{
    [RequireComponent(typeof(Text), typeof(RectTransform))]
    [AddComponentMenu("UI/Effects/Extensions/Cylinder Text")]
    public class CylinderText : BaseMeshEffect
    {
        public float radius = 360;
        private RectTransform rectTrans;


#if UNITY_EDITOR
        protected override void OnValidate()
        {
            base.OnValidate();
            if (rectTrans == null)
                rectTrans = GetComponent<RectTransform>();
        }
#endif
        protected override void Awake()
        {
            base.Awake();
            rectTrans = GetComponent<RectTransform>();
            OnRectTransformDimensionsChange();
        }
        protected override void OnEnable()
        {
            base.OnEnable();
            rectTrans = GetComponent<RectTransform>();
            OnRectTransformDimensionsChange();
        }
		public override void ModifyMesh(VertexHelper helper)
		{
			if (!IsActive() || helper.currentVertCount == 0)
				return;

			List<UIVertex> verts = new List<UIVertex>();
			helper.GetUIVertexStream(verts);

			for (int index = 0; index < verts.Count; index++)
            {
                UIVertex uiVertex = verts[index];

                // get x position
                var x = uiVertex.position.x;                

                // calculate bend based on pivot and radius
                uiVertex.position.z = -radius * Mathf.Cos(x / radius);
                uiVertex.position.x = radius * Mathf.Sin(x / radius);
                
                verts[index] = uiVertex;
            }
        }
    }
}
