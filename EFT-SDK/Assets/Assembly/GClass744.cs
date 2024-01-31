using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

// Token: 0x020007B9 RID: 1977
public static class GClass744
{
	// Token: 0x06002DCC RID: 11724 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearLog()
	{
		throw null;
	}

	// Token: 0x06002DCD RID: 11725 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float ClampAngle(float angle, float min, float max)
	{
		throw null;
	}

	// Token: 0x06002DCE RID: 11726 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float ClampAngle360Sensitive(float angle, float min, float max)
	{
		throw null;
	}

	// Token: 0x06002DCF RID: 11727 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float ZipAngle(float angle)
	{
		throw null;
	}

	// Token: 0x06002DD0 RID: 11728 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetVerticalFovFromHorizontal(float fov, float aspect)
	{
		throw null;
	}

	// Token: 0x06002DD1 RID: 11729 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetHorizontalFovFromVertical(float fov, float aspect)
	{
		throw null;
	}

	// Token: 0x06002DD2 RID: 11730 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetDuration(this AnimationCurve c)
	{
		throw null;
	}

	// Token: 0x06002DD3 RID: 11731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetTime(this AnimationCurve c, float value, float checkFrequency, uint valueOrder = 0U)
	{
		throw null;
	}

	// Token: 0x06002DD4 RID: 11732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float RoundFloatValue(float value, int digits)
	{
		throw null;
	}

	// Token: 0x06002DD5 RID: 11733 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 GetDestination(this NavMeshAgent agent)
	{
		throw null;
	}

	// Token: 0x06002DD6 RID: 11734 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T Do<T>(this T t, Action<T> action)
	{
		throw null;
	}

	// Token: 0x06002DD7 RID: 11735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> DoMap<T>(this IEnumerable<T> t, Action<T> action)
	{
		throw null;
	}

	// Token: 0x06002DD8 RID: 11736 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T[] FillWith<T>(this T[] list, T value)
	{
		throw null;
	}

	// Token: 0x06002DD9 RID: 11737 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<T> FillWith<T>(this List<T> list, T value)
	{
		throw null;
	}

	// Token: 0x06002DDA RID: 11738 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFullPathWithoutExtension(string path)
	{
		throw null;
	}

	// Token: 0x06002DDB RID: 11739 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ToggleStaticRecursively(GameObject go, bool isStatic)
	{
		throw null;
	}

	// Token: 0x06002DDC RID: 11740 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ICollection<T> GetAllComponentsOfType<T>(bool includeInactive) where T : Component
	{
		throw null;
	}

	// Token: 0x06002DDD RID: 11741 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsComponentEnabled<T>(Component component) where T : Component
	{
		throw null;
	}

	// Token: 0x06002DDE RID: 11742 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bounds GetColliderBoundsWithoutRotation(Collider collider)
	{
		throw null;
	}

	// Token: 0x06002DDF RID: 11743 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasTagInParent(this GameObject gameObject, string tag)
	{
		throw null;
	}

	// Token: 0x06002DE0 RID: 11744 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Contains(this LODGroup lodGroup, Renderer renderer)
	{
		throw null;
	}

	// Token: 0x04002C36 RID: 11318
	public static bool False;

	// Token: 0x04002C37 RID: 11319
	public static bool True;

	// Token: 0x04002C38 RID: 11320
	public static bool DisabledForNow;

	// Token: 0x04002C39 RID: 11321
	public static readonly Vector2 Vector2Zero;

	// Token: 0x04002C3A RID: 11322
	public static readonly Vector3 Vector3Zero;

	// Token: 0x04002C3B RID: 11323
	public static readonly Vector4 Vector4Zero;

	// Token: 0x04002C3C RID: 11324
	public static readonly Vector3 Vector3Up;

	// Token: 0x04002C3D RID: 11325
	public static readonly Vector3 Vector3Down;

	// Token: 0x04002C3E RID: 11326
	public static readonly Color WHITE_COLOR;

	// Token: 0x04002C3F RID: 11327
	public static readonly Color GREEN_COLOR;

	// Token: 0x04002C40 RID: 11328
	public static readonly Color YELLOW_COLOR;

	// Token: 0x04002C41 RID: 11329
	public static readonly Color RED_COLOR;

	// Token: 0x020007BA RID: 1978
	public static class GClass745
	{
		// Token: 0x06002DE1 RID: 11745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color ToRTTColor(double rtt)
		{
			throw null;
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color ToLossColor(int loss)
		{
			throw null;
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color ToPlayerRTTColor(double rtt)
		{
			throw null;
		}
	}

	// Token: 0x020007BC RID: 1980
	[CompilerGenerated]
	[Serializable]
	private sealed class Class390<T> where T : Component
	{
		// Token: 0x06002DEA RID: 11754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Scene s)
		{
			throw null;
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GameObject> method_1(Scene s)
		{
			throw null;
		}

		// Token: 0x04002C4A RID: 11338
		public static readonly GClass744.Class390<T> class390_0;

		// Token: 0x04002C4B RID: 11339
		public static Func<Scene, bool> func_0;

		// Token: 0x04002C4C RID: 11340
		public static Func<Scene, IEnumerable<GameObject>> func_1;
	}
}
