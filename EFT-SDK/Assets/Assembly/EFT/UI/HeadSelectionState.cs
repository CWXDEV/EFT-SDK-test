using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x0200291E RID: 10526
	[Serializable]
	public class HeadSelectionState : GClass3012
	{
		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x0600D232 RID: 53810 RVA: 0x00002050 File Offset: 0x00000250
		protected override float TransitionDuration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D233 RID: 53811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(GClass1816.GClass1817 profileData, string[] availableCustomizations, Dictionary<EPlayerSide, PlayerProfilePreview> previews)
		{
			throw null;
		}

		// Token: 0x0600D234 RID: 53812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowState()
		{
			throw null;
		}

		// Token: 0x0600D235 RID: 53813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600D236 RID: 53814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool active)
		{
			throw null;
		}

		// Token: 0x0600D237 RID: 53815 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600D238 RID: 53816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_4()
		{
			throw null;
		}

		// Token: 0x0600D239 RID: 53817 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D23A RID: 53818 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D23B RID: 53819 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task HideState()
		{
			throw null;
		}

		// Token: 0x0600D23C RID: 53820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(PointerEventData pointerData)
		{
			throw null;
		}

		// Token: 0x0600D23D RID: 53821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(int selectedIndex)
		{
			throw null;
		}

		// Token: 0x0600D23E RID: 53822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(int selectedIndex)
		{
			throw null;
		}

		// Token: 0x0600D23F RID: 53823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_10(int selectedIndex)
		{
			throw null;
		}

		// Token: 0x0600D240 RID: 53824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D241 RID: 53825 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_11()
		{
			throw null;
		}

		// Token: 0x0600D242 RID: 53826 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<string> method_12()
		{
			throw null;
		}

		// Token: 0x0600D243 RID: 53827 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<string> method_13()
		{
			throw null;
		}

		// Token: 0x0600D244 RID: 53828 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_14()
		{
			throw null;
		}

		// Token: 0x0400D38A RID: 54154
		[SerializeField]
		private DropDownBox _headSelector;

		// Token: 0x0400D38B RID: 54155
		[SerializeField]
		private DropDownBox _voiceSelector;

		// Token: 0x0400D38C RID: 54156
		private readonly List<EquipmentSlot> _hiddenSlots;

		// Token: 0x0400D38D RID: 54157
		private string[] _availableCustomizations;

		// Token: 0x0400D38E RID: 54158
		private Profile _previewProfile;

		// Token: 0x0400D38F RID: 54159
		private List<KeyValuePair<string, GClass2933>> _headTemplates;

		// Token: 0x0400D390 RID: 54160
		private List<KeyValuePair<string, GClass2937>> _voiceTemplates;

		// Token: 0x0400D391 RID: 54161
		private Dictionary<int, TagBank> _voices;

		// Token: 0x0400D392 RID: 54162
		private int _selectedHeadIndex;

		// Token: 0x0400D393 RID: 54163
		private int _selectedVoiceIndex;

		// Token: 0x0400D394 RID: 54164
		private PlayerProfilePreview _preview;

		// Token: 0x0400D395 RID: 54165
		private GClass1816.GClass1817 _profileData;

		// Token: 0x0400D396 RID: 54166
		private Dictionary<EPlayerSide, PlayerProfilePreview> _previews;

		// Token: 0x02002920 RID: 10528
		[CompilerGenerated]
		private sealed class Class2406
		{
			// Token: 0x0600D247 RID: 53831 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(EquipmentSlot slotType)
			{
				throw null;
			}

			// Token: 0x0600D248 RID: 53832 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GameObject method_1(EquipmentSlot slotType)
			{
				throw null;
			}

			// Token: 0x0400D39B RID: 54171
			public GClass720<EquipmentSlot, PlayerBody.GClass1857> slotViews;
		}

		// Token: 0x02002921 RID: 10529
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2407
		{
			// Token: 0x0600D249 RID: 53833 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GameObject model)
			{
				throw null;
			}

			// Token: 0x0600D24A RID: 53834 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(KeyValuePair<string, GClass2933> x)
			{
				throw null;
			}

			// Token: 0x0600D24B RID: 53835 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_2(KeyValuePair<string, GClass2937> x)
			{
				throw null;
			}

			// Token: 0x0400D39C RID: 54172
			public static readonly HeadSelectionState.Class2407 class2407_0;

			// Token: 0x0400D39D RID: 54173
			public static Func<GameObject, bool> func_0;

			// Token: 0x0400D39E RID: 54174
			public static Func<KeyValuePair<string, GClass2933>, string> func_1;

			// Token: 0x0400D39F RID: 54175
			public static Func<KeyValuePair<string, GClass2937>, string> func_2;
		}
	}
}
