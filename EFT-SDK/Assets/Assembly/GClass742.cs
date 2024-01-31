using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020007B6 RID: 1974
public static class GClass742
{
	// Token: 0x06002DA3 RID: 11683 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Render(Transform T, Vector3 position, Quaternion rotation, int layer, Camera camera, bool fast = true)
	{
		throw null;
	}

	// Token: 0x06002DA4 RID: 11684 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(Transform t, HashSet<Transform> transforms, Matrix4x4 matrix, int layer, Camera camera)
	{
		throw null;
	}

	// Token: 0x06002DA5 RID: 11685 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1(Transform t, HashSet<Transform> transforms, Vector3 position, Quaternion rotation, int layer, Camera camera)
	{
		throw null;
	}

	// Token: 0x06002DA6 RID: 11686 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bounds GetAllBounds(GameObject itemGameObject)
	{
		throw null;
	}

	// Token: 0x06002DA7 RID: 11687 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int NumParents(Transform child, Transform parent, int index = 0)
	{
		throw null;
	}

	// Token: 0x06002DA8 RID: 11688 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LocalRotateAround(this Transform t, Vector3 center, Vector3 eulerRotation)
	{
		throw null;
	}

	// Token: 0x06002DA9 RID: 11689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RotateAround(this Transform t, Vector3 center, Vector3 eulerRotation)
	{
		throw null;
	}

	// Token: 0x06002DAA RID: 11690 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RotateAround(this Transform t, Vector3 center, Vector3 eulerRotation, Quaternion q)
	{
		throw null;
	}

	// Token: 0x06002DAB RID: 11691 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LerpPositionAndRotation(this Transform transform, Vector3 newPos, Quaternion newRot, float t)
	{
		throw null;
	}

	// Token: 0x06002DAC RID: 11692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RotateAround(this Transform t, Vector3 center, Quaternion rot)
	{
		throw null;
	}

	// Token: 0x06002DAD RID: 11693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LookAtAround(this Transform t, Vector3 center, Quaternion rot)
	{
		throw null;
	}

	// Token: 0x06002DAE RID: 11694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 GetPosition(Matrix4x4 m)
	{
		throw null;
	}

	// Token: 0x06002DAF RID: 11695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float Random(this Vector2 v, bool randomizeSign = false)
	{
		throw null;
	}

	// Token: 0x06002DB0 RID: 11696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Quaternion GetRotation(Matrix4x4 m)
	{
		throw null;
	}

	// Token: 0x06002DB1 RID: 11697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetPosRotRelativeToParent(Transform parent, Transform child, out Vector3 position, out Quaternion rotation)
	{
		throw null;
	}

	// Token: 0x06002DB2 RID: 11698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 GetPositionRelativeToParent(Transform parent, Transform child)
	{
		throw null;
	}

	// Token: 0x06002DB3 RID: 11699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Quaternion GetRotationRelativeToParent(Transform parent, Transform child)
	{
		throw null;
	}

	// Token: 0x06002DB4 RID: 11700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Matrix4x4 GetMatrixRelativeToTransform(Transform parent, Transform my, Transform another)
	{
		throw null;
	}

	// Token: 0x06002DB5 RID: 11701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Matrix4x4 GetMatrixRelativeToParent(Transform parent, Transform child)
	{
		throw null;
	}

	// Token: 0x06002DB6 RID: 11702 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Quaternion LocalIdenity(Transform parent, Transform child)
	{
		throw null;
	}

	// Token: 0x06002DB7 RID: 11703 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Transform GetMutualTransform(Transform a, Transform b)
	{
		throw null;
	}

	// Token: 0x06002DB8 RID: 11704 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Transform FindTransformRecursive(Transform root, string name, bool ignoreCase = false)
	{
		throw null;
	}

	// Token: 0x06002DB9 RID: 11705 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Transform FindTransformRecursiveWidthFirst(Transform root, string name)
	{
		throw null;
	}

	// Token: 0x06002DBA RID: 11706 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Transform FindTransformRecursiveContains(Transform root, string name, bool activeInHierarchyOnly = false)
	{
		throw null;
	}

	// Token: 0x06002DBB RID: 11707 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Transform> FindChildsByNameRecNoneAlloc(Transform root, string name, List<Transform> childs, bool activeInHierarchyOnly = false)
	{
		throw null;
	}

	// Token: 0x06002DBC RID: 11708 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Transform FindTransform(this Transform root, string name)
	{
		throw null;
	}

	// Token: 0x06002DBD RID: 11709 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Transform FindTransformWhere(this Transform root, Func<Transform, bool> where)
	{
		throw null;
	}

	// Token: 0x06002DBE RID: 11710 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Transform FindActiveTransformRecursive(Transform root, string name)
	{
		throw null;
	}

	// Token: 0x06002DBF RID: 11711 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_2(Transform root, string searchName, List<Transform> aimList)
	{
		throw null;
	}

	// Token: 0x06002DC0 RID: 11712 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int smethod_3(Transform root, string searchName, List<Transform> yourList, bool activeOnly, params string[] ignore)
	{
		throw null;
	}

	// Token: 0x06002DC1 RID: 11713 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static List<Transform> smethod_4(Transform root, string searchName, bool activeOnly, params string[] ignore)
	{
		throw null;
	}

	// Token: 0x06002DC2 RID: 11714 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int smethod_5(Transform root, string searchName, List<Transform> yourList, bool activeOnly, params string[] ignore)
	{
		throw null;
	}

	// Token: 0x06002DC3 RID: 11715 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static List<Transform> smethod_6(Transform root, string searchName, bool activeOnly, params string[] ignore)
	{
		throw null;
	}

	// Token: 0x06002DC4 RID: 11716 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ParentToInitial(Transform transform, Transform parentTransform)
	{
		throw null;
	}

	// Token: 0x06002DC5 RID: 11717 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetLayersRecursively(GameObject gameObject, int layer)
	{
		throw null;
	}

	// Token: 0x06002DC6 RID: 11718 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetLayersRecursively(GameObject gameObject, int layer, params string[] ignore)
	{
		throw null;
	}

	// Token: 0x06002DC7 RID: 11719 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetLayersRecursively<T>(GameObject gameObject, int layer) where T : Component
	{
		throw null;
	}

	// Token: 0x06002DC8 RID: 11720 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetLayersRecursively<T>(GameObject gameObject, int layer, params string[] ignore) where T : Component
	{
		throw null;
	}
}
