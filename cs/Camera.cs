using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace Lumix
{


	public class Camera : Component
	{
		private int component_id;
		private IntPtr scene;


		public override void create()
		{
			component_id = create(entity._universe, entity._entity_id, "camera");
			scene = getScene(entity._universe, "camera");
		}


		/* NearPlane */
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void setNearPlane(IntPtr scene, int cmp, float source);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static float getNearPlane(IntPtr scene, int cmp);
		
		public float NearPlane
		{
			get{ return getNearPlane(scene, component_id); }
			set{ setNearPlane(scene, component_id, value); }
		}


		/* FarPlane */
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void setFarPlane(IntPtr scene, int cmp, float source);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static float getFarPlane(IntPtr scene, int cmp);
		
		public float FarPlane
		{
			get{ return getFarPlane(scene, component_id); }
			set{ setFarPlane(scene, component_id, value); }
		}


		/* OrthoSize */
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void setOrthoSize(IntPtr scene, int cmp, float source);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static float getOrthoSize(IntPtr scene, int cmp);
		
		public float OrthoSize
		{
			get{ return getOrthoSize(scene, component_id); }
			set{ setOrthoSize(scene, component_id, value); }
		}


		/* FOV */
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void setFOV(IntPtr scene, int cmp, float source);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static float getFOV(IntPtr scene, int cmp);
		
		public float FOV
		{
			get{ return getFOV(scene, component_id); }
			set{ setFOV(scene, component_id, value); }
		}


	}

}