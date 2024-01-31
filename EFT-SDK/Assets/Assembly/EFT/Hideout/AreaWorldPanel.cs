using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.Hideout
{
	// Token: 0x02001B9E RID: 7070
	public sealed class AreaWorldPanel : AreaPanel
	{
		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x060094BE RID: 38078 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060094BF RID: 38079 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060094C0 RID: 38080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060094C1 RID: 38081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetInfo()
		{
			throw null;
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_2(bool offscreen)
		{
			throw null;
		}

		// Token: 0x060094C4 RID: 38084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPointOfView(bool firstPerson)
		{
			throw null;
		}

		// Token: 0x060094C5 RID: 38085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPosition(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x060094C6 RID: 38086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool visible)
		{
			throw null;
		}

		// Token: 0x060094C7 RID: 38087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060094C8 RID: 38088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060094CA RID: 38090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Init(AreaData data, Action<AreaPanel> onSelected)
		{
			throw null;
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060094CC RID: 38092 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool smethod_0(ref AreaWorldPanel.Struct531 struct531_0)
		{
			throw null;
		}

		// Token: 0x04009B8C RID: 39820
		public const float FADE_DURATION = 0.8f;

		// Token: 0x04009B8D RID: 39821
		private const float float_1 = 10f;

		// Token: 0x04009B8E RID: 39822
		[SerializeField]
		private CanvasGroup _labelsGroup;

		// Token: 0x04009B8F RID: 39823
		[SerializeField]
		private CanvasGroup _panelCanvasGroup;

		// Token: 0x04009B90 RID: 39824
		[SerializeField]
		private Vector2 _restrictedBorder;

		// Token: 0x04009B91 RID: 39825
		[SerializeField]
		private Vector2 _cameraOffset;

		// Token: 0x04009B92 RID: 39826
		private bool bool_1;

		// Token: 0x04009B93 RID: 39827
		private Coroutine coroutine_0;

		// Token: 0x04009B94 RID: 39828
		private Vector3 vector3_0;

		// Token: 0x04009B95 RID: 39829
		private bool bool_2;

		// Token: 0x04009B96 RID: 39830
		private bool bool_3;

		// Token: 0x04009B97 RID: 39831
		private float float_2;

		// Token: 0x04009B98 RID: 39832
		private float float_3;

		// Token: 0x02001B9F RID: 7071
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1672
		{
			// Token: 0x060094CD RID: 38093 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(AreaRequirement x)
			{
				throw null;
			}

			// Token: 0x060094CE RID: 38094 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Requirement x)
			{
				throw null;
			}

			// Token: 0x04009B99 RID: 39833
			public static readonly AreaWorldPanel.Class1672 class1672_0;

			// Token: 0x04009B9A RID: 39834
			public static Func<AreaRequirement, bool> func_0;

			// Token: 0x04009B9B RID: 39835
			public static Func<Requirement, bool> func_1;
		}

		// Token: 0x02001BA1 RID: 7073
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		public struct Struct531
		{
			// Token: 0x04009BA1 RID: 39841
			public Vector3 pos;

			// Token: 0x04009BA2 RID: 39842
			public Vector2 screenSize;

			// Token: 0x04009BA3 RID: 39843
			public Vector2 restrictedBorder;
		}
	}
}
