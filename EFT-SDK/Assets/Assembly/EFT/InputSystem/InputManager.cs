using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.InputSystem
{
	// Token: 0x02001A57 RID: 6743
	public sealed class InputManager : MonoBehaviour
	{
		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06008E73 RID: 36467 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008E74 RID: 36468 RVA: 0x00002050 File Offset: 0x00000250
		public GDelegate68 TranslateDelegate
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06008E75 RID: 36469 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static InputManager Create(KeyGroup[] keyGroups, AxisGroup[] settingsAxisGroups, float doubleClickTime, bool deliverInputOnUpdates)
		{
			throw null;
		}

		// Token: 0x06008E76 RID: 36470 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static InputManager smethod_0(GameObject gameObject, KeyGroup[] keyGroups, AxisGroup[] settingsAxisGroups, float doubleClickTime, bool deliverInputOnUpdates)
		{
			throw null;
		}

		// Token: 0x06008E77 RID: 36471 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateBindings(KeyGroup[] keyGroups, AxisGroup[] settingsAxisGroups, float doubleClickTimeout)
		{
			throw null;
		}

		// Token: 0x06008E78 RID: 36472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(KeyGroup[] keyGroups, AxisGroup[] settingsAxisGroups, float doubleClickTime)
		{
			throw null;
		}

		// Token: 0x06008E79 RID: 36473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06008E7A RID: 36474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06008E7B RID: 36475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06008E7C RID: 36476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x06008E7D RID: 36477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GClass2909 calledEvent)
		{
			throw null;
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(List<ECommand> commandsList, float[] axesList)
		{
			throw null;
		}

		// Token: 0x06008E80 RID: 36480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06008E81 RID: 36481 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass2909 raisedEvent)
		{
			throw null;
		}

		// Token: 0x040095BB RID: 38331
		public static readonly EKeyPress[,] UpdateInputMatrix;

		// Token: 0x040095BC RID: 38332
		[SerializeField]
		public bool SuperSmooth;

		// Token: 0x040095BD RID: 38333
		[SerializeField]
		public bool DeliverInputOnUpdates;

		// Token: 0x040095BE RID: 38334
		public Action<bool> CursorVisibilityChanged;

		// Token: 0x040095BF RID: 38335
		private static GameObject gameObject_0;

		// Token: 0x040095C0 RID: 38336
		private bool bool_0;

		// Token: 0x040095C1 RID: 38337
		private static GClass1895 gclass1895_0;

		// Token: 0x040095C2 RID: 38338
		private bool bool_1;

		// Token: 0x040095C3 RID: 38339
		private readonly List<ECommand> list_0;

		// Token: 0x040095C4 RID: 38340
		private readonly List<ECommand> list_1;

		// Token: 0x040095C5 RID: 38341
		private readonly float[] float_0;

		// Token: 0x040095C6 RID: 38342
		[CompilerGenerated]
		private GDelegate68 gdelegate68_0;

		// Token: 0x040095C7 RID: 38343
		private ECursorResult ecursorResult_0;

		// Token: 0x040095C8 RID: 38344
		private bool bool_2;

		// Token: 0x040095C9 RID: 38345
		private Action action_0;

		// Token: 0x02001A58 RID: 6744
		[CompilerGenerated]
		private sealed class Class1588
		{
			// Token: 0x06008E82 RID: 36482 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1892 groupCombination)
			{
				throw null;
			}

			// Token: 0x040095CA RID: 38346
			public GClass1892 current;
		}

		// Token: 0x02001A59 RID: 6745
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1589
		{
			// Token: 0x06008E83 RID: 36483 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass1892 combination, IEnumerable<GClass1892> allCombinations)
			{
				throw null;
			}

			// Token: 0x06008E84 RID: 36484 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(GClass1892 current, IEnumerable<GClass1892> allCombinations)
			{
				throw null;
			}

			// Token: 0x040095CB RID: 38347
			public static readonly InputManager.Class1589 class1589_0;

			// Token: 0x040095CC RID: 38348
			public static Action<GClass1892, IEnumerable<GClass1892>> action_0;
		}
	}
}
