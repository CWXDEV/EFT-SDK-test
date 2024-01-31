using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

// Token: 0x020000DB RID: 219
public static class GClass5
{
	// Token: 0x0600048C RID: 1164 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject InstantiatePrefab(this Transform parent, GameObject prefab)
	{
		throw null;
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T InstantiatePrefab<T>(this Transform parent, GameObject prefab) where T : MonoBehaviour
	{
		throw null;
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T InstantiatePrefab<T>(this GameObject parent, GameObject prefab) where T : MonoBehaviour
	{
		throw null;
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(this Transform parent, bool onlyActive = false)
	{
		throw null;
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DestroyAllChildren(this GameObject parent, bool onlyActive = false)
	{
		throw null;
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ParentFake(this Transform child, Transform parent)
	{
		throw null;
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PreventMaterialChangeInEditor(this Renderer renderer)
	{
		throw null;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material CopyToPreventMaterialChangeInEditor(this Material material)
	{
		throw null;
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SmartEnable(this GameObject @object)
	{
		throw null;
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SmartEnableWithoutHierarchy(this GameObject @object)
	{
		throw null;
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task SmartEnableAsync(this GameObject @object, float delay, Action<Transform> onTick = null)
	{
		throw null;
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SmartDisable(this GameObject @object)
	{
		throw null;
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SmartDisableWithoutHierarchy(this GameObject @object)
	{
		throw null;
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1(GameObject @object, bool value)
	{
		throw null;
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_2(GameObject @object)
	{
		throw null;
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_3(GameObject @object, bool value)
	{
		throw null;
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Task smethod_4(float delay, GameObject @object, Action<Transform> onTick)
	{
		throw null;
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
	{
		throw null;
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Component GetOrAddComponent(this GameObject gameObject, Type type)
	{
		throw null;
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GetOrAddComponent<T>(this MonoBehaviour component) where T : Component
	{
		throw null;
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFullPath(this Transform transform, bool withSceneName = false)
	{
		throw null;
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Transform FindObjectByFullPath(string path)
	{
		throw null;
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<T> GetComponentsInChildrenActiveIgnoreFirstLevel<T>(this Transform transform) where T : Component
	{
		throw null;
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GetComponentInChildrenActiveIgnoreFirstLevel<T>(this Transform transform) where T : Component
	{
		throw null;
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_5(Component component, Transform firstLevel)
	{
		throw null;
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T AddComponentCopy<T>(this GameObject go, T source) where T : Component
	{
		throw null;
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Transform> GetChildren(this Transform transform)
	{
		throw null;
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetActiveWithCheck(this GameObject go, bool active)
	{
		throw null;
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_6(ref GClass5.Struct3 struct3_0)
	{
		throw null;
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_7(Transform transform, ref GClass5.Struct3 struct3_0)
	{
		throw null;
	}

	// Token: 0x020000DD RID: 221
	[CompilerGenerated]
	[Serializable]
	private sealed class Class85
	{
		// Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(MultiFlareLight flare)
		{
			throw null;
		}

		// Token: 0x040005FC RID: 1532
		public static readonly GClass5.Class85 class85_0;

		// Token: 0x040005FD RID: 1533
		public static Func<MultiFlareLight, bool> func_0;
	}

	// Token: 0x020000DE RID: 222
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct3
	{
		// Token: 0x040005FE RID: 1534
		public List<Transform> objectsChildren;

		// Token: 0x040005FF RID: 1535
		public Action<Transform> onTick;
	}

	// Token: 0x020000E0 RID: 224
	[CompilerGenerated]
	private sealed class Class86
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GameObject o)
		{
			throw null;
		}

		// Token: 0x0400060A RID: 1546
		public string part;

		// Token: 0x0400060B RID: 1547
		public Func<GameObject, bool> func_0;
	}
}
